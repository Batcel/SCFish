/*---------------StartkSDK(�ֽ�����)����----------------- *create by batcel at 2021-4-20 */

 #if ScFish

using System.Runtime.InteropServices;using UnityEngine;using StarkSDKSpace;public class CByteGame{
    private static CByteGame ByteGameSDKInstance = null;

    public delegate void CallBackFunc(object pragma);

    private static CallBackFunc AdPlayFuncCallBack;

    StarkAdManager.BannerAd m_bannerAdIns = null;
    StarkAdManager.InterstitialAd m_InterAdIns = null;

    private static readonly string ByteGameAppID = "tt75f50348eacdc7f907";
    private static readonly string ExcitingVideoAdID = "dhmk23k9eb4oj48ogc";
    private static readonly string InterstitialAdID = "pdoibg64a9h1kwlgp4";
    private static readonly string BannerAdID = "11a8h9hai66i4oe5l8";

    public static CByteGame Instance()
    {
        if (ByteGameSDKInstance == null)
        {
            ByteGameSDKInstance = new CByteGame();

            if (Application.isEditor)
            {
                MockSetting.OpenAllMockModule();
                MockSetting.SwithMockModule(MockModule.FollowDouyin, true);               
            }
        }
        return ByteGameSDKInstance;
    }

    /// <summary>
    /// �жϵ�ǰ����ӿ���Container���Ƿ����ʹ�ã���������ʹ���������û�
    /// </summary>
    /// <param name="caniuse">�Ƿ����</param>
    /// <returns></returns>
    private bool ShowTipsWhenDontUse(bool caniuse)
    {
        if (Application.platform == RuntimePlatform.Android && !caniuse)
        {
            UnityEngine.Debug.LogError("��ǰ������Container�汾���ͣ�����ʹ�øýӿ�");
            AndroidUIManager.ShowToast("��ǰ������Container�汾���ͣ�����ʹ�øýӿ�");
        }

        return caniuse;
    }

    public void PlayExcitingVideo(System.Action<bool> PlayVideoCallback = null)
    {
        DebugLog.Log("������Ƶ����");
        ShowTipsWhenDontUse(CanIUse.StarkAdManager.ShowVideoAdWithId);
        StarkSDK.API.GetStarkAdManager().ShowVideoAdWithId(ExcitingVideoAdID,
            (bComplete) => { PlayVideoCallback(bComplete); }, OnAdError);
    }

    #region ��ע�����˺�

    void FollowAweme()
    {
        DebugLog.Log("��ע�����˺�");
        ShowTipsWhenDontUse(CanIUse.FollowDouYinUserProfile);
        StarkSDK.API.FollowDouYinUserProfile(OnFollowAwemeCallback, OnFollowAwemeError);
    }

    void OnFollowAwemeCallback()
    {
        DebugLog.Log("OnFollowAwemeCallback");
    }

    void OnFollowAwemeError(int errCode, string errMsg)
    {
        DebugLog.Log(string.Format("OnFollowAwemeError errCode {0} errMsg {1}", errCode, errMsg));
    }

    #endregion


    #region ���Բ���AD

    void CreateInterstitialAd()
    {
        ShowTipsWhenDontUse(CanIUse.StarkAdManager.CreateInterstitialAd);
        DebugLog.Log("��������AD");
        //if (m_InterAdIns == null)
        //    m_InterAdIns = StarkSDK.API.GetStarkAdManager().CreateInterstitialAd("fcdjfqabkdrd70cdja", false, OnAdError, null, () => { PrintText("����������"); m_InterAdIns.Show(); });
        //else
        //{
        //    m_InterAdIns = StarkSDK.API.GetStarkAdManager().CreateInterstitialAd("fcdjfqabkdrd70cdja", true, OnAdError, () => { PrintText("�������ر�"); }, () => { PrintText("����������"); });
        //}
        m_InterAdIns = StarkSDK.API.GetStarkAdManager().CreateInterstitialAd(InterstitialAdID, OnAdError,
            () => { DebugLog.Log("�������ر�"); }, () => { DebugLog.Log("����������"); });
    }

    void LoadInterstitialAd()
    {
        if (m_InterAdIns != null)
            m_InterAdIns.Load();
        else
        {
            DebugLog.Log("����ADδ����");
        }
    }


    void ShowInterstitialAd()
    {
        DebugLog.Log("��ʾ����AD");
        if (m_InterAdIns != null)
            m_InterAdIns.Show();
        else
        {
            DebugLog.Log("����ADδ����");
        }
    }

    void DestoryInterstitialAd()
    {
        DebugLog.Log("���ٲ���AD");
        if (m_InterAdIns != null)
            m_InterAdIns.Destory();
        m_InterAdIns = null;
    }

    void OnAdError(int iErrCode, string errMsg)
    {
        DebugLog.Log("���� �� " + iErrCode + "  " + errMsg);
    }

    #endregion

    #region ����BannerAD

    public void Create_ShowBannerAd()
    {
        DebugLog.Log("Banner��沥��");
        ShowTipsWhenDontUse(CanIUse.StarkAdManager.CreateBannerAd);
        if (m_bannerAdIns == null)
        {
            //ʹ��uc������Ŀ��bannerid
            StarkAdManager.BannerStyle testStyle = new StarkAdManager.BannerStyle();
            testStyle.top = 10;
            testStyle.left = 10;
            testStyle.width = 320;
            m_bannerAdIns = StarkSDK.API.GetStarkAdManager().CreateBannerAd(BannerAdID, testStyle, 60,
                OnAdError, OnBannerLoaded, OnBannerResize);
        }
        else
        {
            m_bannerAdIns.Show();
        }
    }

    void ShowBannerAd()
    {
        if (m_bannerAdIns != null)
            m_bannerAdIns.Show();
    }

    public void HideBannerAd()
    {
        if (m_bannerAdIns != null)
            m_bannerAdIns.Hide();
    }

    void DestroyBannerAd()
    {
        if (m_bannerAdIns != null)
        {
            m_bannerAdIns.Destory();
            m_bannerAdIns = null;
        }
    }

    public void ResizeBannerAd()
    {
        StarkAdManager.BannerStyle tmpStyle = new StarkAdManager.BannerStyle();
        tmpStyle.left = 50;
        tmpStyle.top = 200;
        tmpStyle.width = 380;
        if (m_bannerAdIns != null)
            m_bannerAdIns.ReSize(tmpStyle);
    }

    void OnBannerLoaded()
    {
        DebugLog.Log("Banner������");
        if (m_bannerAdIns != null)
            m_bannerAdIns.Show();
    }

    void OnBannerResize(int width, int height)
    {
        DebugLog.Log("Banner��ʽ�ı� �� " + width + "  " + height);
    }

    #endregion

}

#endif

