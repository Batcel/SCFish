

#if UNITY_IOS
using UnityEngine;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System;
using System.Linq;

/// <summary>
/// IOS�¸�֧��ƽ̨���ܽӿ�
/// </summary>
public class WechatPlatfrom_IOS
{
    //IOS֧����jiezhang�ӿ�
    //[DllImport("__Internal")]
    //public static extern void MayunJieZhang_IOS(string paystr);
    public static void MayunJieZhang_IOS(string paystr)
    {

    }

     //΢�ŷ���ӿ�URL
    [DllImport("__Internal")]
    public static extern void ShowAppUpdateTips(string AppStoreUrl);

    //΢��IOS֧���ӿ�
    [DllImport("__Internal")]
    private static extern void WeChatLgoinJieZhang_IOS(string prepayId,string noncestr,string timestr,string signstr);

    //΢���Ƿ�װ
    [DllImport("__Internal")]
    public static extern bool WeChat_IsWXAppInstalled();

    //΢�ŵ�½��Ȩ�ӿ�
    [DllImport("__Internal")]
    public static extern void  WeChat_AuthLogin();

    //΢�ŷ���ӿ�ͼƬ
    [DllImport("__Internal")]
    public static extern void WeChat_ShareImage(bool isTimeline);

    //΢�ŷ���ӿ�ͼƬ
    [DllImport("__Internal")]
    public static extern void WeChat_ShareImageByPath(string ImgPath,bool isTimeline);

    //΢�ŷ���ӿ��ı�
    [DllImport("__Internal")]
    public static extern void WeChat_ShareText(string sharetxt,bool isTimeline);
   
    //΢�ŷ���ӿ�URL
    [DllImport("__Internal")]
    public static extern void WeChat_ShareURL(string URLtxt,string descpxt,bool isTimeline);

    //�ֻ���ص���
    [DllImport("__Internal")]
    public static extern float GetBatteryLevel();

    public static string MD5Encrypt(string input)    {        MD5 md5 = new MD5CryptoServiceProvider();        byte[] t = md5.ComputeHash(Encoding.UTF8.GetBytes(input));        StringBuilder sb = new StringBuilder(32);        for (int i = 0; i < t.Length; i++)            sb.Append(t[i].ToString("x").PadLeft(2, '0'));        return sb.ToString();    }    /// <summary>    /// ����΢��֧��ǩ��    /// </summary>    /// <param name="paras"></param>    /// <returns></returns>    private static string GenerateSignString(ref Dictionary<string, string> paramsMap)    {
        //Dictionary<string, string> sortDic = paramsMap.OrderBy(o => o.Key).ToDictionary(o => o.Key, o => o.Value);

        var sortDic = (from objDic in paramsMap orderby objDic.Key ascending select objDic);
        List<string> tmp = new List<string>();        foreach (var kv in sortDic)        {            tmp.Add(string.Format("{0}={1}", kv.Key, kv.Value));        }        tmp.Add("key=" + PayPlatformDefine.WxApiKey);        //string[] sortKeyArray = tmp.ToArray();        var signTmp = string.Join("&", tmp.ToArray());        var result = MD5Encrypt(signTmp).ToUpper();        return result;    }

    /// <summary>    /// ����΢��֧��    /// </summary>
    public static void WXLgoinJieZhang_IOS(string prepayId,string noncestr)
    {
        Dictionary<string, string> paras = new Dictionary<string, string>();        paras.Add("appid", PayPlatformDefine.WXAPPID);
        paras.Add("noncestr", noncestr); //����ַ���
        paras.Add("partnerid", PayPlatformDefine.WXMCH_ID); //�̻���        paras.Add("prepayid", prepayId); //Ԥ֧������ID ����Ǻ�̨��΢�ŷ�����������΢�ŷ���������֧���������������������ͻ���        paras.Add("package", "Sign=WXPay"); //����д�̶�ֵSign=WXPay             Int32 timestamp = (Int32)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;        paras.Add("timestamp", timestamp.ToString());

        string signStr = GenerateSignString(ref paras);//Ӧ��ǩ��

        WeChatLgoinJieZhang_IOS(prepayId,noncestr,timestamp.ToString(),signStr);
    }

    private static IEnumerator CaptureScreenRectShot(Canvas cans, RectTransform rect,bool bTimeLine)
    {

        Rect targetRect = GameFunction.GetSpaceRect(cans, rect, cans.worldCamera);

        Int32 timestamp = (Int32)(DateTime.Now.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;        string screenshotname = GameDefine.ScreenshotSavePath + timestamp.ToString() + ".png";
        yield return new WaitForEndOfFrame();
        Texture2D tex = new Texture2D((int)targetRect.width, (int)targetRect.height, TextureFormat.RGBA32, false);

        tex.ReadPixels(targetRect, 0, 0);
        tex.Apply();
        File.WriteAllBytes(screenshotname, tex.EncodeToPNG());

        while (!File.Exists(screenshotname))        {
            yield return new WaitForSeconds(0.05f);        }
        
        WeChat_ShareImageByPath(screenshotname,bTimeLine);
    } 


   //΢�ŷ�����Ļ�����ͼͼƬ(true����Ȧ��false����)
    public static bool WeChat_ShareRectImage(Canvas cans,RectTransform rect,bool bTimeLine)    {
        GameMain.SC(CaptureScreenRectShot(cans,rect,bTimeLine));
        return true;    }
}

#endif