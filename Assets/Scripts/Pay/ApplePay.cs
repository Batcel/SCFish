#if UNITY_IOSusing UnityEngine.Purchasing;using UnityEngine;using System.Net;
using System.Text;
using System.IO;
using System;
using UnityEngine.Networking;
using System.Collections.Generic;

public class ApplePay :  IStoreListener{
    public static ApplePay Instance = new ApplePay();

    //IAP�����صĶ���m_Controller��洢����Ʒ��Ϣ
    private IStoreController m_Controller;    private IAppleExtensions m_AppleExtensions;    /// <summary>
    /// �Ƿ��ڹ��������
    /// </summary>    private bool bPurchaseInProgress;

    private bool bInitUnityPurchaseSuceess;

    private string WaitingBuyProductId;

    private ApplePay()
    {
        WaitingBuyProductId = string.Empty;
        bPurchaseInProgress = false;
        bInitUnityPurchaseSuceess = false;
        //InitUnityPurchase();
    }

    //��ʼ��֧������
    public void InitUnityPurchase(List<uint> productlist)    {        if (bInitUnityPurchaseSuceess)            return;        bPurchaseInProgress = false;        var module = StandardPurchasingModule.Instance();        var builder = ConfigurationBuilder.Instance(module);

        //��ʼ�̵���Ʒ
        foreach(var productId in productlist)
        {
            builder.AddProduct(productId.ToString(), ProductType.Consumable);
        }

        UnityPurchasing.Initialize(this, builder);    }


    //��ʼ���ɹ��ص�
    public void OnInitialized(IStoreController controller, IExtensionProvider extensions)    {        m_Controller = controller;

        // On Apple platforms we need to handle deferred purchases caused by Apple's Ask to Buy feature.  
        // On non-Apple platforms this will have no effect; OnDeferred will never be called.  
        IAppleExtensions m_AppleExtensions = extensions.GetExtension<IAppleExtensions>();        m_AppleExtensions.RegisterPurchaseDeferredListener(OnDeferred);

        //Product product = m_Controller.products.WithID("GameCityDiamondT1");

        Debug.Log("OnInitialized: Success");
        bInitUnityPurchaseSuceess = true;

        if(WaitingBuyProductId != string.Empty)
        {
            BuyItem(WaitingBuyProductId);
        }

        //���Թ���һ������
        //BuyItem("GameCityTestItem1");
    }

    //��ʼ��ʧ�ܻص�
    public void OnInitializeFailed(InitializationFailureReason error)    {        Debug.Log("Billing failed to initialize!");        switch (error)        {            case InitializationFailureReason.AppNotKnown:                Debug.LogError("Is your App correctly uploaded on the relevant publisher console?");                break;            case InitializationFailureReason.PurchasingUnavailable:
                // Ask the user if billing is disabled in device settings.
                Debug.Log("Billing disabled!");                break;            case InitializationFailureReason.NoProductsAvailable:
                // Developer configuration error; check product metadata.
                Debug.Log("No products available for purchase!");                break;        }    }

    /// <summary>
    /// ����ɹ�����
    /// </summary>
    /// <param name="args"></param>
    /// <returns></returns>
    public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs args)    {

        Debug.Log("Purchase OK: " + args.purchasedProduct.definition.id);
        Debug.Log("Receipt: " + args.purchasedProduct.receipt);

        
        var jsonobj = new JSONObject(args.purchasedProduct.receipt);
        Dictionary<string, string> result = jsonobj.ToDictionary();   
        string receiptPayload = result["Payload"];
        //Debug.Log("xxxxx jsonreceipt payload:" + receiptPayload);

        //����Ϊ������֤����ȷ�����ǰ�json���͸��������������������ȥapple itune��֤
        string json = "{\"receipt-data\":\"" + receiptPayload + "\"}";
        //VerifyReceipt(json);

        Player.SendBuyReceiptToServer(PayPlatform.Apple,json);
        //���������ѽ������ȴ���������֤���
        Player.BuyEnd();

        bPurchaseInProgress = false;
        return PurchaseProcessingResult.Complete;    }

   public void VerifyReceipt(string receiptstr)
    {
        try
        {
            byte[] postBytes = Encoding.UTF8.GetBytes(receiptstr);

            //��ʽ��ַ
            //var req = HttpWebRequest.Create("https://buy.itunes.apple.com/verifyReceipt");
            //���Ե�ַ
            var req = HttpWebRequest.Create("https://sandbox.itunes.apple.com/verifyReceipt");
            req.Method = "POST";
            req.ContentType = "application/json";
            req.ContentLength = postBytes.Length;

            using (var stream = req.GetRequestStream())
            {
                stream.Write(postBytes, 0, postBytes.Length);
                stream.Flush();
            }

            var sendResp = req.GetResponse();
            string sendRespText = "";
            using (var streamReader = new System.IO.StreamReader(sendResp.GetResponseStream()))
            {
                sendRespText = streamReader.ReadToEnd().Trim();
            }

            var jsonobj = new JSONObject(sendRespText);
            Dictionary<string, string> result = jsonobj.ToDictionary();

            Debug.Log("receipt return data:" + sendRespText);

            foreach (var a in result)
            {
                Debug.Log(a.Key + ":" + a.Value);
            }
        }
        catch (System.Exception ex)
        {
            Debug.Log("Exception: " + ex.Message.ToString());
        }
    }

    private void ResponseCallback(IAsyncResult asyncResult)
    {
        HttpWebRequest request = (HttpWebRequest)asyncResult.AsyncState;
        // ��ȡResponse
        HttpWebResponse response = request.EndGetResponse(asyncResult) as HttpWebResponse;
        if (response.StatusCode == HttpStatusCode.OK)
        {

            // ��ȡ��������
            Stream responseStream = response.GetResponseStream();
            byte[] buff = new byte[2048];
            MemoryStream ms = new MemoryStream();
            int len = -1;
            while ((len = responseStream.Read(buff, 0, buff.Length)) > 0)
            {
                ms.Write(buff, 0, len);
            }
            Debug.Log("receipt back mmmmmmmdata:" + Encoding.Default.GetString(ms.GetBuffer()));
            // �������
            responseStream.Close();
            response.Close();
            request.Abort();
        }
    }

    //����ʧ�ܻص�
    public void OnPurchaseFailed(Product item, PurchaseFailureReason r)    {        Debug.Log("Purchase failed: " + item.definition.id);        Debug.Log(r);        bPurchaseInProgress = false;        Player.BuyEnd();    }


    //�����ӳ���ʾ
    private void OnDeferred(Product item)    {        Debug.Log("Purchase deferred: " + item.definition.id);
    }


    //������
    public void BuyItem(string productId)    {
        //�̳ǻ�û�г�ʼ���ɹ������빺�ﳵ
        if (bInitUnityPurchaseSuceess == false)
        {           
            WaitingBuyProductId = productId;
            return;
        }
        if(bPurchaseInProgress)
        {
            Debug.Log("��һ�ι���δ����");
            return;
        }

        if (m_Controller != null)
        {
             var product = m_Controller.products.WithID(productId);             if (product != null && product.availableToPurchase)            {
                //����֧��  
                bPurchaseInProgress = true;
                m_Controller.InitiatePurchase(productId);
            }
        }
    }
}
#endif