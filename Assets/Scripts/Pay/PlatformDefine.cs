using UnityEngine;using XLua;


/// <summary>/// ƽ̨�����Ϣ����/// </summary>[LuaCallCSharp]public class PayPlatformDefine
{
#if UNITY_EDITOR || UNITY_STANDALONE_WIN
    //΢����ҳӦ��
    public static readonly string WXAPPID = "wxf39b6dff0f6cfa3c";                    //΢��ƽ̨��������ҳӦ��APPID
    public static readonly string WXAppSECRET = "11c3fc63708b065201824f0959dd0924";  //΢��ƽ̨���ɵ���ҳӦ��APP SECRET
#else
    public static readonly string WXAPPID = "wx043094aaa5449b38";                    //΢��֧��ƽ̨������Ӧ��APPID
    public static readonly string WXAppSECRET = "f892d5043cc07087c1f992b837692218";  //΢��ƽ̨���ɵ�APP SECRET  
#endif
    public static readonly string WXMCH_ID = "1515219211";                           //΢��֧���̻�ID 
    public static readonly string WxApiKey = "DjukmAw87yhgwi2SnagvHqsfzmstrc6x";     //΢��API��Կ
}