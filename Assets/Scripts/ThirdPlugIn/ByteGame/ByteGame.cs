/*---------------StartkSDK(字节跳动)接入----------------- *create by batcel at 2021-4-20 */

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
    /// 判断当前这个接口在Container下是否可以使用，若不可以使用则提醒用户
    /// </summary>
    /// <param name="caniuse">是否可用</param>
    /// <returns></returns>
    private bool ShowTipsWhenDontUse(bool caniuse)
    {
        if (Application.platform == RuntimePlatform.Android && !caniuse)
        {
            UnityEngine.Debug.LogError("当前宿主的Container版本过低，不可使用该接口");
            AndroidUIManager.ShowToast("当前宿主的Container版本过低，不可使用该接口");
        }

        return caniuse;
    }

    public void PlayExcitingVideo(System.Action<bool> PlayVideoCallback = null)
    {
        DebugLog.Log("激励视频播放");
        ShowTipsWhenDontUse(CanIUse.StarkAdManager.ShowVideoAdWithId);
        StarkSDK.API.GetStarkAdManager().ShowVideoAdWithId(ExcitingVideoAdID,
            (bComplete) => { PlayVideoCallback(bComplete); }, OnAdError);
    }

    #region 关注抖音账号

    void FollowAweme()
    {
        DebugLog.Log("关注抖音账号");
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


    #region 测试插屏AD

    void CreateInterstitialAd()
    {
        ShowTipsWhenDontUse(CanIUse.StarkAdManager.CreateInterstitialAd);
        DebugLog.Log("创建插屏AD");
        //if (m_InterAdIns == null)
        //    m_InterAdIns = StarkSDK.API.GetStarkAdManager().CreateInterstitialAd("fcdjfqabkdrd70cdja", false, OnAdError, null, () => { PrintText("插屏广告加载"); m_InterAdIns.Show(); });
        //else
        //{
        //    m_InterAdIns = StarkSDK.API.GetStarkAdManager().CreateInterstitialAd("fcdjfqabkdrd70cdja", true, OnAdError, () => { PrintText("插屏广告关闭"); }, () => { PrintText("插屏广告加载"); });
        //}
        m_InterAdIns = StarkSDK.API.GetStarkAdManager().CreateInterstitialAd(InterstitialAdID, OnAdError,
            () => { DebugLog.Log("插屏广告关闭"); }, () => { DebugLog.Log("插屏广告加载"); });
    }

    void LoadInterstitialAd()
    {
        if (m_InterAdIns != null)
            m_InterAdIns.Load();
        else
        {
            DebugLog.Log("插屏AD未创建");
        }
    }


    void ShowInterstitialAd()
    {
        DebugLog.Log("显示插屏AD");
        if (m_InterAdIns != null)
            m_InterAdIns.Show();
        else
        {
            DebugLog.Log("插屏AD未创建");
        }
    }

    void DestoryInterstitialAd()
    {
        DebugLog.Log("销毁插屏AD");
        if (m_InterAdIns != null)
            m_InterAdIns.Destory();
        m_InterAdIns = null;
    }

    void OnAdError(int iErrCode, string errMsg)
    {
        DebugLog.Log("错误 ： " + iErrCode + "  " + errMsg);
    }

    #endregion

    #region 测试BannerAD

    public void Create_ShowBannerAd()
    {
        DebugLog.Log("Banner广告播放");
        ShowTipsWhenDontUse(CanIUse.StarkAdManager.CreateBannerAd);
        if (m_bannerAdIns == null)
        {
            //使用uc测试项目的bannerid
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
        DebugLog.Log("Banner广告加载");
        if (m_bannerAdIns != null)
            m_bannerAdIns.Show();
    }

    void OnBannerResize(int width, int height)
    {
        DebugLog.Log("Banner样式改变 ： " + width + "  " + height);
    }

    #endregion

}

#endif

