using XLua;
/// <summary>
/// ��Ϸ����ö��
/// </summary>
[LuaCallCSharp]
public enum GameKind_Enum{    GameKind_None = -1,    GameKind_CarPort,           //����
    GameKind_DiuDiuLe,          //������						
    GameKind_LaBa,              //����
    GameKind_ForestDance,       //ɭ�����
    GameKind_BlackJack,         //21��
    GameKind_FiveInRow,         //������
    GameKind_TexasPoker,        //�����˿�
    GameKind_LandLords,         //������
    GameKind_BullHundred,       //����ţţ  ����
    GameKind_BullAllKill,		//ͨɱţţ  5��
    GameKind_Fishing,           //����
    GameKind_BullHappy,         //��ׯţţ
    GameKind_Mahjong,           //�齫
    GameKind_GuanDan,			//�走
    GameKind_YcMahjong,         //�γ��齫
    GameKind_CzMahjong,			//�����齫
    GameKind_LuckyTurntable,    //������
    GameKind_GouJi,             //����
    GameKind_HongZhong,         //�����齫
    GameKind_Answer,            //������
    GameKind_Chess,             //����
    GameKind_Max}

[LuaCallCSharp]
public enum GameTye_Enum
{
    GameType_Normal,
    GameType_Contest,
    GameType_Appointment,
    GameType_Record,
}

//��roomser ��ԭ��
enum GameReason_enum
{
    GameReason_Match = 0,       //ƥ�����
    GameReason_Contest,     //��������
    GameReason_Appoint,		//Լ�ֽ���
};

public enum GameState_Enum
{
    GameState_Luancher = 0,  //��Դ������״̬
    GameState_Login,         //��½״̬
    GameState_Hall,          //����״̬
    GameState_Game,          //��Ϸ״̬
    GameState_Contest,       //����״̬
    GameState_Appointment,   //Լ��״̬
}


//------------------------------------------------------------------------------
//��Ϣ���Ͷ��壬���������Ϣ�����豣��һ��
//------------------------------------------------------------------------------
namespace GameCity
{
    public enum EMSG_ENUM
    {
        CrazyCityMsg_BEGIN = 0,
        CrazyCityMsg_ROOMSERLOGIN,                      //��Ϸ��������½
        CrazyCityMsg_PLAYERLOGIN,                       //��ҵ�½
        CrazyCityMsg_BACKPLAYERLOGIN,                   // �������ظ���ҵ�½
        CrazyCityMsg_PLAYERDATA,                        //ƽ̨���ͨ����ȥ��Ϸ���ݿ�
        CrazyCityMsg_PLAYERLOGINSUCCESS,                //��ҵ�½�ɹ�
        CrazyCityMsg_CHANGENICKNAME,                    //����޸��ǳ�
        CrazyCityMsg_BACKCHANGENAME,                    //�ظ��޸��ǳ�
        CrazyCityMsg_BACKROOMSER,                       //loginser �ظ� roomser
        CrazyCityMsg_PLAYERAPPLYGAME,                   //����������ĳ����Ϸ
        CrazyCityMsg_BACKAPPLYGAME,                     //�ظ��������ĳ��Ϸ
        CrazyCityMsg_GETROLEDATA,                       // g->L ȥlogin�������������
        CrazyCityMsg_BACKROLEDATA,                      // �ظ�����
        CrazyCityMsg_RESULTTOLOGIN,                     // G->L һ����Ϸ�����󱣴��������
        CrazyCityMsg_RESULTTODB,                        // L->D һ����Ϸ�����󱣴��������	
        CrazyCityMsg_SAVEROLEDATATODB,                  // ����������ݵ����ݿ�
        CrazyCityMsg_LETROOMSERDOWNPLAYER,              //�÷����������ĳ��Ҷ���
        CrazyCityMsg_SERVERCUTCONNECT,                  //�������Ͽ���������ӣ����ţ�
        CrazyCityMsg_ROLELEAVEROOMSER,                  //��ҶϿ��뷿���������
        CrazyCityMsg_RECHARGE,                          //��ֵ
        CrazyCityMsg_BACKRECHARGE,                      //�ظ���ֵ
        CrazyCityMsg_GETCLUBDATAFROMDB,                 //L->D ��ȡdb��club ��Ǯ���а� �ʽ������
        CrazyCityMsg_BACKCLUBDATATOLOGIN,               //D->L �ظ�club���ݵ��ͻ���


        CrazyCityMsg_PLAYER_REQESTBUY,                  //���������
        CrazyCityMsg_PLAYER_BUYVERIFY,                  //��ҹ�����������������֤
        CrazyCityMsg_PLAYER_BUYRESULT,                  //��ҹ�����
        CrazyCityMsg_PLAYER_UPDATEMONEY,                //������ҵĻ�����ֵ���ͻ���
        CrazyCityMsg_PAYSERVERLOGIN,                    //֧����������½login
        CrazyCityMsg_SENDRECHARGETOPAY,                 //L->P login���ͳ�ֵ��Ϣ��pay��֤
        CrazyCityMsg_BACKRECHARGEPAY,                   //P->L payserver��֤��ɺ�ظ���Ϣ��login
        CrazyCityMsg_TRADEAPPPAYINFO,                   //P->L L->C ֧��������Ϣ
        CrazyCityMsg_PLAYERVIPLEVELUP,                  //���vip�ȼ�������
        CrazyCityMsg_LOGINLOGSERVER,                    //������������½log������
        CrazyCityMsg_GETROOMINFO,                       //L->R login��ȡ�������������������
        CrazyCityMsg_BACKROOMINFO,                      //�ظ�
        CrazyCityMsg_GMTOOLACOUNTLOGIN,                 //GM�����˺ŵ�½
        CrazyCityMsg_BACKCHECKGMACCOUNT,                //�ظ�GM�˺ŵ�½
        CrazyCityMsg_GMTOOLADDITEMALL,                  //GM������ӵ���
        CrazyCityMsg_BACKGMTOOLADDITEM,                 //�ظ�GM������ӵ���
        CrazyCityMsg_MOBILELOGIN,                       //�ֻ������½
        CrazyCityMsg_CHECKINDENTIFYING,                 //�ͻ�����֤��
        CrazyCityMsg_BACKCHECKINDENTIFYING,             //�ظ�
        CrazyCityMsg_PLAYERBINGUSEID,                   //L->D ��Ұ�useid
        CrazyCityMsg_BACKMOBILELOGIN,                   //�������ظ���� ��ȡ��֤��
        CrazyCityMsg_CHECKMOBILEISBIND,                 //L->D ȥ���ݿ��м����ֻ����Ƿ��Ѿ���
        CrazyCityMsg_BACKCHECKMOBILEISBIND,             //D->L �ظ�login���ֻ����Ƿ��
        CrazyCityMsg_UPDATECOINRANKDATATOLOGIN,         //D->L ���ͽ�Ǯ������login
        CrazyCityMsg_UPDATECOINRANKDATATOCLINT,         //L->C ���ͽ�Ǯ������clint
        CrazyCityMsg_NEEDUPDATECOINRANK,                //��Ҫ���½�Ǯ���а�
        CrazyCityMsg_PLAYERGETCOINRANK,                 //��һ�ȡ��Ǯ���а�
        CrazyCityMsg_CHANGERELIEF,                      //�޸ľȼý����
        CrazyCityMsg_BACKCHANGERELIEF,                  //֪ͨ�ͻ���
        CrazyCityMsg_CHANGERELIEFTOROOMSER,             //ȥ����������޸�������ӵľȼý�
        CrazyCityMsg_BEFOREGAMEOVER,                    //������ߺ�֮ǰ����Ϸ������
        CrazyCityMsg_SAVEJACKPOTHANDSELTODB,            //����ʽ𽱳ص����ݿ�
        CrazyCityMsg_SENDJACKPOTHANDSELTOLOGIN,         //���Ͳʽ𽱳����ݵ�login
        CrazyCityMsg_RUNHORSELIGHTDATA,                 //G->L L->C ��������ݵ�login
        CrazyCityMsg_SENDGOODSTATE,                     //L->P login�������ֵ��Ϣ  �Ƿ񷢻��ɹ�
        CrazyCityMsg_NOTSENDGOODDATATOLOGIN,            //P->L payserver send data to login
        CrazyCityMsg_LETPAYSENDGOODDATA,                //L->P ��������� ��pay���� loginserver ����
        CrazyCityMsg_GMCLOSETALLSERVER,                 //GM�������ر����з�����
        CrazyCityMsg_GETROLECLUBGIVEDATATOLOGIN,        //L->D ������ҹ�����������
        CrazyCityMsg_SENDROLECLUBGIVEDATATOLOGIN,       //D->L ������ҹ����������ݵ�login
        CrazyCityMsg_SAVEROLECLUBGIVEDATATODB,          //L_>D ���湤���������ݵ�db
        CrazyCityMsg_GETROLECLUBGIVEDATA,               //C->L �ͻ������󹤻���������
        CrazyCityMsg_SENDROLECLUBGIVEDATATOCLINT,       //L->C ���������͹����������ݵ�clint
        CrazyCityMsg_PLAYERREMOVECLUBGIVEDATA,          //C->L ����Ƴ�������������
        CrazyCityMsg_CHANGECLUBACCEPTCOINTODB,          //L->D ֪ͨ���ݿ����ù����������
        CCMsg_FIVEINROW_CM_INVATECLUBMEMBER,
        CCMsg_FIVEINROW_SM_BACKINVATECLUBMEMBER,        //���빤���Ա������Ϸ
        CCMsg_FIVEINROW_CM_ISAGREEINVATE,
        CCMsg_FIVEINROW_SM_BACKISAGREEINVATE,       //�Ƿ�ͬ������
        CrazyCityMsg_CM_PLAYERAPPLYBINDINVITE,              //��������������
        CrazyCityMsg_SM_PLAYERAPPLYBINDINVITE,              //�ظ�
        CrazyCityMsg_PLAYERBINDINVITETODB,              //ȥ���ݿⱣ��
        CrazyCityMsg_CM_ROBOTAISERVERLOGIN,             //�����˷�������½
        CrazyCityMsg_SM_ROBOTAISERVERLOGIN,             //�ظ�
        CrazyCityMsg_NEEDAIROBOTTOLOGIN,                //G->L ֪ͨlogin ��Ҫ�� ai ������
        CrazyCityMsg_SM_ADDAIROBOTTOGAME,               //L->C login ������Ϣ�� robotser ��ӻ�����
        CrazyCityMsg_CM_BACKADDAIROBOTTOGAME,           //C->L �ظ�
        CrazyCityMsg_LETLOGINCUTAIROBOT,                //G->L ֪ͨlogin �ر�ĳ�� ai
        CrazyCityMsg_STOPPLAYERGAME,                    //���Ǯ�ҵ���Ӯ�Ѿ��ﵽ������
        CrazyCityMsg_RESERTEVERYDAYDATE,                //��ֵÿ��ĵ�һЩ����
        CrazyCityMsg_UPDATERANDOMGAMEROLENUM,			//ͬ�������Ϸ�ϵ��������ͻ���
        CrazyCityMsg_SAVECLUBREBATETODB,                //�᳤�����ߵ�ʱ���Ա��ֵ������db
        CrazyCityMsg_GETWEEKOROLDREWORD,                //��ȡ�ܽ��� ���������
        CrazyCityMsg_BACKWEEKOROLDREWORD,               //�ظ������
        CrazyCityMsg_CHECKINVITETODB,                   //L->D loginȥdb�ϼ���������
        CrazyCityMsg_BACKCHECKINVITETOLOGIN,            //L->D �ظ�
        CrazyCityMsg_FIRSTADDCLUBREWORD,                //��һ�μ�����ֲ��Ľ���
        CrazyCityMsg_CM_SENDHORNTOALL,                  //�ͻ��˷����������ݵ�������
        CrazyCityMsg_SM_SENDHORNTOALL,                  //����������
        CrazyCityMsg_BACK_SENDHORNTOALL,                //�ظ�������Ŀͻ���
        CrazyCityMsg_SENDADDLOTTERYTOCLINT,				//�������ӽ�ȯ��������Ϣ���ͻ���
        CrazyCityMsg_PLAYERGETTRADEINFO,                //�����ȡ��ȯ�һ���Ϣ
        CrazyCityMsg_BACKGETTRADEINFO,				    //�ظ���ȯ�һ���¼
        CrazyCityMsg_REDBAGBEGIN,                       //���ʼ
        CrazyCityMsg_REDBAGEND,                         //�����
        CrazyCityMsg_PLAYERGETREDBAG,                   //��������ȡ���
        CrazyCityMsg_BACKPLAYERREDBAG,					//�ظ�
        CrazyCityMsg_PALYERGETACTIVITYINFO,             //��������û�б�
        CrazyCityMsg_BACKGETACTIVITYINFO,				//huifu 
        CrazyCityMsg_GETTODAYREDBAGINFO,                //��һ�ȡ��ǰ�������
        CrazyCityMsg_BACKTODAYREDBAGINFO,				//�ظ�
        CrazyCityMsg_PLAYERLOGINFAILED,					//��ҵ�½ʧ�� ��Ϊ
        CrazyCityMsg_SETLETTRORYCOVERT,                 //����ʵ��һ�����
        CrazyCityMsg_GETROLEFISHCANNONINFO,             //L->D��ȡ������̨����
        CrazyCityMsg_BACKROLEFISHCANNONINFO,            //D-L����
        CrazyCityMsg_AFTERPLAYERBUGCANNON,              //��ҹ�������̨�󱣴����ݿ�
        CrazyCityMsg_AFTERPLAYERUSEFISHSKILL,           //���ʹ���꼼��֮�󱣴�
        CrazyCityMsg_REWORDFISHINGSKILL,                //������Ҳ���ļ��ܻ���ʹ�ô���
        CrazyCityMsg_REQUESTPLAYERPACKETINFO,           //������ҵı�������
        CrazyCityMsg_SENDPLAYERPACKETINFO,              //������ұ�������
        CrazyCityMsg_SAVEPLAYERPACKETINFO,              //������ұ�������
        CrazyCityMsg_UPDATEPLAYERPACKETINFO,			//��ұ������ݸ��µİ¿ͻ���
        CrazyCityMsg_APPLAYGETMAILREWORDDATA,           //��������ȡ�ʼ�
        CrazyCityMsg_BACKGETMAILREWORDDATA,             //֪ͨ�����ȡ�ʼ�����Ʒ
        CrazyCityMsg_REQUESTPLAYERMAILINFO,             //������ҵ��ʼ�����
        CrazyCityMsg_SENDPLAYERMAILINFO,                //��������ʼ�����
        CrazyCityMsg_SAVEPLAYERMAILINFO,                //��������ʼ�����
        CrazyCityMsg_UPDATEPLAYERGETMAIL,					//֪ͨ����յ�һ���ʼ�
        CrazyCityMsg_SAVEAPPOINTLOG,                //����Լ��log�����ݿ�
        CrazyCityMsg_SENDPLAYERAPPOINT,             //�������Լ�ּ�¼
        CrazyCityMsg_GETROLELOGDATA,                //��ȡ�������������
        CrazyCityMsg_CM_PLAYERLEAVEROOMSER,         //��������뿪���������
        CrazyCityMsg_SM_PLAYERLEAVEROOMSER,			//�ظ�
        CrazyCityMsg_SM_PLAYERDISORRECONNECT,       //��ҵ��߻�����������
        CrazyCityMsg_SM_MIDDLEENTERCONTEST,         //��;�������
        CrazyCityMsg_PLAYER_QUERYSTATE,             //��������ѯ��ǰ������״̬
        CrazyCityMsg_PLAYER_QUERYSTATE_REPLY,       //�ظ���������ѯ��ǰ������״̬
        CrazyCityMsg_APPLYVIDEOSERIPPORT,           //�����ȡvideoser ip port
        CrazyCityMsg_BACKVIDEOSERIPPORT,			//�ظ�
        CrazyCityMsg_APPLYTOBEONLOOKER,             //�������Χ��
        CrazyCityMsg_BACKTOBEONLOOKER,              //�ظ�
        CrazyCityMsg_GAMEINFOTOONLOOKERS,			//��Ϸ�е�������͸�Χ����
        CrazyCityMsg_CM_APPLYENTERROOMANDSIT,//����������ĳ����ĳ��λ
        CrazyCityMsg_SM_APPLYENTERROOMANDSIT,//�ظ�
        CrazyCityMsg_SM_UPDATEENTERROOMANDSIT,//ͬ�����������������
        CrazyCityMsg_SM_UPDATEENTERROOMANDSITTOREADYALL,//ͬ����׼����������������
        CrazyCityMsg_CM_APPLYLEAVEROOMANDSIT,//��������뿪ĳ����ĳ��λ
        CrazyCityMsg_SM_APPLYLEAVEROOMANDSIT,//�ظ�
        CrazyCityMsg_SM_UPDATELEAVEROOMANDSIT,//ͬ�����������������
        CrazyCityMsg_SM_UPDATELEAVEROOMANDSITTOREADYALL,//ͬ����׼����������������
        CrazyCityMsg_SM_UPDATEBEFOREHANDROOMINFO,   //ͬ��׼�������������Ϣ��
        CrazyCityMsg_CM_APPLYREADY,         //�������׼��
        CrazyCityMsg_SM_APPLYREADY,         //�ظ�
        CrazyCityMsg_SM_UPDATEAPPLYREADY,       //ͬ����ȥ
        CrazyCityMsg_CM_APPLYCANCLEREADY,   //�������ȡ��׼��
        CrazyCityMsg_SM_APPLYCANCLEREADY,   //�ظ�
        CrazyCityMsg_SM_UPDATEAPPLYCANCLEREADY,//ͬ����ȥ
        CrazyCityMsg_CM_UPDATEBEFOREHANDROOMINFO,//�������׼��������������
        CrazyCityMsg_CM_APPLYCHANGESIT,     //���뻻��λ
        CrazyCityMsg_SM_ASKTOCHANGESIT,     //ѯ�ʶԷ��Ƿ�ͬ�⻻��λ
        CrazyCityMsg_CM_ANSWERTOCHANGESIT,  //�ظ�
        CrazyCityMsg_SM_APPLYCHANGESIT,     //�����Ƿ�ͬ�⻻��λ
        CrazyCityMsg_SM_UPDATECHANGESIT,    //�����ɹ���
        CrazyCityMsg_CM_APPLYQUITSTARTGAME, //���ٽ��뷿��
        CrazyCityMsg_SM_BACKQUITSTARTGAME,	//�ظ�
        CrazyCityMsg_SM_KICKOUTROOM,		//��ΪһЩԭ��T����Ϸ����
        CrazyCityMsg_SM_LOGINSERDISCONNECT,	//loginserδ�������Ժ�
        CrazyCityMsg_GETROLEOTHERDATE,      //��ȡ�����������
        CrazyCityMsg_SENDGAMEMASTERSCORE,   //����������Ϸ�Ĵ�ʦ��
        CrazyCityMsg_SAVEGAMEMASTERSCORE,   //����������Ϸ�Ĵ�ʦ��
        CrazyCityMsg_UPDATERECHARGETOROOMSER,//��ֵ�ɹ���ͬ��������������뷿�����������
        CrazyCityMsg_BACKMOMENTDATATOLOGIN,             //D->L �ظ�moment���ݵ��ͻ���
        CrazyCityMsg_APPLYANNOUNCEMENTDATA,     //������빫��
        CrazyCityMsg_BACKANNOUNCEMENTDATA,      //�ظ�
        CrazyCityMsg_ANNOUNCEMENTNEEDUPDATE,	//������֪ͨ�������������Ҫ���¹�����
        CrazyCityMsg_APPBACKSTATENOTIFYGAMESERVER,//APP�л�����̨״ֵ̬֪ͨ��Ϸ������(��ʱ�����������״̬)
        CrazyCityMsg_ADDROLECREDITSCOREEVERYDAY,    //L->D ÿ�춨ʱ�������������
        CrazyCityMsg_BACKADDROLECREDITSCOREEVERYDAY,//D->L db������֮�� ֪ͨloginser
        CrazyCityMsg_SAVEPLAYERGAMESTATISTICSDATA,  //���������Ϸͳ�����ݵ����ݿ�
        CrazyCityMsg_SENDPLAYERGAMESTATISTICSDATA,  //���������Ϸͳ�����ݵ�
        CrazyCityMsg_APPLYPLAYERGAMESTATISTICSDATA, //���������Ϸͳ������
        CrazyCityMsg_UPDATEMASTERRANKTOLOGIN,       //D->L ���ʹ�ʦ��������login
        CrazyCityMsg_TELLMASTERRANKNEEDUPDATE,      //֪ͨ�ͻ��˴�ʦ�����а���Ҫ����
        CrazyCityMsg_APPLYMASTERRANKTOLOGIN,		//��������ʦ�����а�
        CrazyCityMsg_SENDCONTESTCHAMPIONINFO,       //���ͱ����ھ����鵽�ͻ���
        CrazyCityMsg_TELLCONTESTCHAMPIONNEEDUPDATE, //֪ͨ�ͻ��˱����ھ��б���Ҫ����
        CrazyCityMsg_APPLYCONTESTCHAMPIONINFO,      //�����������ھ��б�
        CrazyCityMsg_GETPLAYERPROXYDATATOGLOGIN,    //loginser��ȡ��Ҵ�������
        CrazyCityMsg_SENDPLAYERPROXYDATATOGLOGIN,   //��Ҵ������ݵ�loginser
        CrazyCityMsg_ADDNEWPLAYERPROXYDATA,         //�ͻ�����������µĴ���
        CrazyCityMsg_BACKADDNEWPLAYERPROXYDATA,     // �ظ�
        CrazyCityMsg_APPLYIMPROVEDINDENTITY,        //��������ĳ�˴������
        CrazyCityMsg_BACKIMPROVEDINDENTITY,         //�ظ�
        CrazyCityMsg_ADDRECHARGEREBATE,             //������ҳ�ֵ�����ܶ�
        CrazyCityMsg_ADDWINREBATE,                  //�������ӮǮ��ˮ�ܶ�
        CrazyCityMsg_GAMESERADDPLAYERBOTTOM,        //�������Ϸ�в�����ˮ
        CrazyCityMsg_EMOTION,						//������
        CrazyCityMsg_CashToDiamond,                 //����һ���ʯ
        CrazyCityMsg_SendContestData,               //������Ҵ�����������
        CrazyCityMsg_UpdateContestData,
        CrazyCityMsg_ReqContestRankData,
        CrazyCityMsg_SendContestRankData,

        //΢�Ź��ں��ֽ�����Ϣ
        CrazyCityMsg_PL_QUERYWXCASHREDBAGAMOUNT = 491,  //֧��ƽ̨��������login��ѯ���ں��û�΢���ֽ������
        CrazyCityMsg_LP_REPLYWXCASHREDBAGAMOUNT,        //login�ظ�֧��ƽ̨���������ں��û�΢���ֽ������
        CrazyCityMsg_PL_RECEVIEDWXCASHREDBAGSUCESS,     //֧��ƽ̨������֪ͨlogin�����ȡ���ں��ֽ����ɹ�
        CrazyCityMsg_BackPlayerWxQRAuthCode,            //�ظ����΢��ɨ���ά���½��Ȩ��code

        //����ϵͳ��Ϣ
        ContestMsg_Begin = 500,                           //����ϵͳ��ʼ
        ContestMsg_ContestSvrRegitserToLogin,             //������ע�ᵽlogin
        ContestMsg_GameServerRegitserToContest,           //��Ϸ��ע�ᵽcontest ��
        ContestMsg_ContestInfoList,                       //�������еı�����Ϣ��login
        ContestMsg_RequestContestInfo,                    //�ͻ������������Ϣ
        ContestMsg_ContestInfoChange,                     //ĳ��������Ϣ��״̬���ͬ����login
        ContestMsg_PlayerEnroll,                          //��ұ�������
        ContestMsg_PlayerEnrollReply,                     //��ұ����������   
        ContestMsg_PlayerCancelEnroll,                    //���ȡ������
        ContestMsg_PlayerCancelEnrollReply,               //���ȡ���������
        ContestMsg_NotifiyPlayerAdmission,                //֪ͨ����볡
        ContestMsg_PlayerRequestAdmission,                //��������볡
        ContestMsg_PlayerAdmissionReply,                  //����볡�ظ�
        ContestMsg_PlayerExitContest,                     //����˳�����
        ContestMsg_PlayerExitContestReply,                //����˳������ظ�
        ContestMsg_NotifyStartContest,                    //֪ͨlogin������ʼ
        ContestMsg_NotifyPlayerStartContest,              //֪ͨ��ұ�����ʼ
        ContestMsg_RoundEndDeskRoleRank,                  //����һ�ֽ������ϵ���ҵ�ǰ�������(���͸�gamesvr)
        ContestMsg_ContestEnd,                            //��������
        ContestMsg_ContestDeskRoleScore,                  //ÿ����Ϸ��������һ����ϱ�����Ϊ��λ��
        ContestMsg_PlayerPromotionRank,                   //��ҽ����������
        ContestMsg_ContestScoreRank,                      //���������������
        ContestMsg_GiveOutReward,                         //�������ν���
        ContestMsg_ContestPlayerDeskDivide,               //����������ŷ������ݷ��͸�GameServer
        ContestMsg_GameServerCreateDeskReply,             //��Ϸ����������������Ϸ���ӻظ�
        ContestMsg_NotifyGameServerStartGame,             //֪ͨ��Ϸ��������ʼ��Ϸ������Ϊ��λ��
        ContestMsg_PlayerEnterGameServerContestDesk,      //��ҽ��������Ϸ����������
        ContestMsg_ContestPlayerByePromotion,             //��������ֿս���
        ContestMsg_ContestDisband,                        //��������ĳ״̬δ�ﵽ������ɢ����
        ContestMsg_PacketContestInfoToGameServer,         //��ʼ��������������ݸ���Ϸ��������������������ÿ�ֽ�������
        ContestMsg_RefreshGameingDeskCount,               //ˢ����Ϸ״̬�е�������
        ContestMsg_RequestDeskInfo,                       //����������������Ϣ(��Ϸ�У���Ϸ����)
        ContestMsg_PacketDeskInfo,                        //�������������Ϣ(��Ϸ�У���Ϸ����)
        ContestMsg_PlayerRequestLookOnDesk,               //��������Թ�ĳ��������
        ContestMsg_BackDeskInfoToPlayer,                  //�ظ���ұ������ӵ���Ϣ
        ContestMsg_RequestGameingRank,                    //���������Ϸ�����е����а�
        ContestMsg_BackGameingRankToPlayer,               //�ظ������Ϸ�����е����а�
        ContestMsg_UpdatePlayerRankAfterOneOver,          //һ�������� �����Ѿ���������ҵ�����
        ContestMsg_PacketContestRoleScoreRank,            //�����ұ����������а񣨸���������
        ContestMsg_RequestbuyEnterNextRound,              //�����������һ�ֱ������ʸ�
        ContestMsg_RequestbuyEnterNextRoundReply,         //���������һ�ֱ����ʸ������ظ�
        ContestMsg_SeekSubstitutes,                       //֪ͨgamesvr�油����
        ContestMsg_RequestSubstitutes,                    //��������Ϊ�油
        ContestMsg_RequestSubstitutesReply,               //����油����ظ�
        ContestMsg_RoundTimeOverForceEndGameingDesk,      //һ�ֱ�����ʱ����ǿ�ƽ�����Ϸ�еı�����(֪ͨ��Ϸ��)
        ContestMsg_PlayerVideoRecordData,                 //��ұ�����¼��Ƶ����
        ContestMsg_PlayerDisConnectAtConntestState,       //����ڱ���״̬�¶Ͽ����ӣ�login֪ͨ����������
        ContestMsg_EnrollDisband_NotifyPlayer,            //��������״̬��ɢ����֪ͨ���
        ContestMsg_AdmissionDisband_NotifyPlayer,         //�����볡״̬��ɢ����֪ͨ���
        ContestMsg_CommandContestDisband,                 //�����ɢ����

        //�Խ�����
        Contestmsg_PlayerCreateContestRequest = 580,       //����Խ���������
        Contestmsg_PlayerCreateContestReply,               //����Խ���������ظ�
        Contestmsg_PlayerDisbandCreateContestReq,          //��ҽ�ɢ�Խ���������
        Contestmsg_PlayerDisbandCreateContestReply,        //��ҽ�ɢ�Խ������ظ�
        Contestmsg_AnyTimeContestCurPlayerCount,           //��������ǰ��������
        ContestMsg_ChineseChessRankingList,                //������������񵥣�����������֯���鿴���

        //������Ϣ
        AppointmentInit = 600,
        Appointment_CM_Join_1,
        Appointment_SM_Join_1,
        Appointment_CM_Join_2,
        Appointment_SM_Join_2,
        Appointment_CM_Create,
        Appointment_SM_Create,
        Appointment_CM_Exit,
        Appointment_SM_Exit,
        Appointment_CM_Switch,
        Appointment_SM_Switch,
        Appointment_CM_AgreeSwitch,
        Appointment_SM_AgreeSwitch,
        Appointment_CM_Ready,
        Appointment_SM_Ready,
        Appointment_SM_StartGame,
        Appointment_SM_ConnectGameServer,
        Appointment_SM_GameBackLogin,
        Appointment_SM_GameResult,
        Appointment_CM_Record,
        Appointment_SM_Record,
        Appointment_SM_TellLoginGameIndex,              //֪ͨlogin �ڼ��ֽ�����
        Appointment_SM_RecycleRoom,						//���շ���
        Appointment_SM_ClearReady,
        Appointment_CM_PublicRooms,                     //����������Ϣ
        Appointment_SM_PublicRooms,

        //����Ȧ��Ϣ
        Friends_Moments_CM_Init = 700,
        Friends_Moments_CM_Info,
        Friends_Moments_SM_Info,
        Friends_Moments_CM_Create,
        Friends_Moments_SM_Create,
        Friends_Moments_CM_Break,
        Friends_Moments_SM_Break,
        Friends_Moments_CM_AgreeJoin,
        Friends_Moments_SM_AgreeJoin,
        Friends_Moments_CM_Exit,
        Friends_Moments_SM_Exit,
        Friends_Moments_CM_Join,
        Friends_Moments_SM_Join,
        Friends_Moments_CM_KickOut,
        Friends_Moments_SM_KickOut,
        Friends_Moments_CM_CreateTable,
        Friends_Moments_SM_CreateTable,
        Friends_Moments_CM_BuyFriendsDiamond,
        Friends_Moments_SM_BuyFriendsDiamond,
        Friends_Moments_CM_LoginOrExit,               //��Ա������
        Friends_Moments_SM_LoginOrExit,
        Friends_Moments_CM_ChangeContent,                   //�޸Ĺ���
        Friends_Moments_SM_ChangeContent,
        Friends_Moments_CM_MemberChangeNameOrIcon,      //��Ա�޸����ƺ�ͷ��	
        Friends_Moments_SM_MemberChangeNameOrIcon,
        Friends_Moments_CM_JoinFriendsTable,
        Friends_Moments_SM_JoinFriendsTable,
        Friends_Moments_CM_CloseTable,
        Friends_Moments_SM_CloseTable,
        Friends_Moments_CM_BRIEFINFO,
        Friends_Moments_SM_BRIEFINFO,
        Friends_Moments_CM_Record,
        Friends_Moments_SM_Record,                  //����Ȧ��Ϸ��¼
        Friends_Moments_CM_AddRecord,
        Friends_Moments_SM_AddRecord,               //����Ȧ��Ӽ�¼
        Friends_Moments_CM_LeaveFriendsTable,
        Friends_Moments_SM_LeaveFriendsTable,       //�뿪����Ȧ����

        //ʤ��ideo
        CCVideoMsg_Begin = 1000,
        CCVideoMsg_RegisterToLogin,             //
        CCVideoMsg_BeginSet,                    //��ʼ��ʱ����������ݵ�videoser
        CCVideoMsg_BackBeginSet,                //����videoid
        CCVideoMsg_TellLoginVideoID,            //֪ͨlogin ���videoid
        CCVideoMsg_TotalRoundScore,             //�ܵ�ÿ����ҵĻ���
        CCVideoMsg_SendRoundScoreToClint,       //���͸����
        CCVideoMsg_SendStepInfoToSer,           //ÿ�������ݸ�videoser
        CCVideoMsg_SendStepInfoToClint,         //ÿ�������ݸ����
        CCVideoMsg_ApplyGetRoundScore,          //��������ȡÿ�ֵĻ���
        CCVideoMsg_ApplyGetStepInfo,            //��������ȡÿ������ϸ������

        //gate
        CCGateMsg_Begin = 2000,
        CCGateMsg_GateLoginMaster,                              //gateȥmaster��ע��
        CCGateMsg_MasterBackGateLogin,                          //�ظ�
        CCGateMsg_GateLoginLoginSer,                            //gateȥlogin��ע��
        CCGateMsg_LoginSerBackGateLogin,                        //�ظ�
        CCGateMsg_RoomSerLoginGateSer,                          //�����������½gateser
        CCGateMsg_BackRoomSerLoginGateSer,                      //�ظ�
        CCGateMsg_LetRoomSerConnectGateSer,                     //��̬����gateser�� ��roomserȥ����
        CCGateMsg_PlayerApplyLoginGame,                         //����������ܷ�����ȥ��½��Ϸ
        CCGateMsg_BackPlayerLoginGame,                          //�ظ�
        CCGateMsg_PlayerReqConnIdForWxQR,                       //������������connId����΢��ɨ���ά���½
        CCGateMsg_BackPlayerReqConnIdForWxQR,                   //�ظ�������������connId����΢��ɨ���ά���½
        CCGateMsg_UpdateConnectNum,								//gateser �� ������������

        //������Ϣ�Ŀ�ʼ
        CrazyCityMsg_CARPORT_BEGIN = 100000,

        //��������Ϣ�Ŀ�ʼ
        CrazyCityMsg_DIUDIULE_BEGIN = 100100,

        //������Ϣ�Ŀ�ʼ
        CrazyCityMsg_LABA_BEGIN = 100200,

        //ɭ�������Ϣ�Ŀ�ʼ
        CrazyCityMsg_FOREST_BEGIN = 100300, 

        //21����Ϣ�Ŀ�ʼ
        CCMsg_BLACKJACK_BEGIN = 100400,
        CCMsg_BLACKJACK_CM_LOGIN,
        CCMsg_BLACKJACK_SM_LOGIN,
        CCMsg_BLACKJACK_CM_CHOOSElEVEL,
        CCMsg_BLACKJACK_SM_CHOOSElEVEL,
        CCMsg_BLACKJACK_SM_ENTERROOM,       //ѡ��ȼ�֮�� ֱ�ӽ��뷿��
        CCMsg_BLACKJACK_SM_BOSSCHANGE,      //������ׯ
        CCMsg_BLACKJACK_SM_BOSSDOWN,        //ׯ����ׯ
        CCMsg_BLACKJACK_CM_APPLYSITDOWN,    //�����������
        CCMsg_BLACKJACK_SM_APPLYSITDOWN,    //�ظ�
        CCMsg_BLACKJACK_CM_APPLYSTADN,      //�������վ����
        CCMsg_BLACKJACK_SM_APPLYSTADN,      //�ظ�
        CCMsg_BLACKJACK_SM_DEALPOKERSTOPLAYER,//����
        CCMsg_BLACKJACK_SM_ENTERGAMESTATE,      //���߿ͻ��� ����״̬
        CCMsg_BLACKJACK_SM_ASKBUYSAFECOIN,      //ѯ���Ƿ���Ҫ������
        CCMsg_BLACKJACK_CM_ANSWERBUYSAFE,       //��һظ� ������
        CCMsg_BLACKJACK_SM_AGREEBUYSAFE,        //�����ͬ������֮�� �ظ�
        CCMsg_BLACKJACK_SM_ASKDOUBLEORNEED,     //ѯ����Ҫ�ӱ�����Ҫ����
        CCMsg_BLACKJACK_CM_ANSWERDOUBLEORNEED,  //�ظ�
        CCMsg_BLACKJACK_SM_ANSWERDOUBLEORNEED,  //ͬ����ѯ�ʵ��˵���Ϣ���������
        CCMsg_BLACKJACK_CM_APPLYBEBOSS,         //������ׯ
        CCMsg_BLACKJACK_SM_APPLYBEBOSS,         //�ظ�
        CCMsg_BLACKJACK_SM_CUTPOKERS,           //ѯ������Ƿ�Ҫ����
        CCMsg_BLACKJACK_CM_APPLYLEAVEROOM,      //��������뿪����
        CCMsg_BLACKJACK_SM_APPLYLEAVEROOM,      //�ظ�
        CCMsg_BLACKJACK_SM_SITPLAYERLEAVEROOM,  //���µ�����뿪����
        CCMsg_BLACKJACK_CM_CHIPIN,              //�����ע
        CCMsg_BLACKJACK_SM_CHIPIN,              //�ظ�
        CCMsg_BLACKJACK_CM_APPLYBOSSLIST,       //���������ׯ�б�
        CCMsg_BLACKJACK_SM_APPLYBOSSLIST,       //
        CCMsg_BLACKJACK_CM_AAPLYCHANGEROOM,     //���뻻����
        CCMsg_BLACKJACK_SM_OPENBOSSHOLDPOKE,    //ׯ�Ҵ򿪿��ŵ���
        CCMsg_BLACKJACK_SM_BUYSAFECOINRESULT,	//�����ս����� �Ľ�������ͻ���
        CCMsg_BLACKJACK_SM_NICKOUTROOMFORCOIN,	//��ΪǮ������T������


        //��������Ϣ�Ŀ�ʼ
        CCMsg_FIVEINROW_BEGIN = 100500,
        CCMsg_FIVEINROW_CM_LOGIN,
        CCMsg_FIVEINROW_SM_LOGIN,
        CCMsg_FIVEINROW_CM_CHOOSElEVEL,
        CCMsg_FIVEINROW_SM_CHOOSElEVEL,
        CCMsg_FIVEINROW_CM_CREATEROOM,  //��������
        CCMsg_FIVEINROW_SM_CREATEROOM,  //�ظ�
        CCMsg_FIVEINROW_SM_SENDTABLEINFO,//���ͷ������ݸ��ͻ���
        CCMsg_FIVEINROW_CM_ENTERROOM,   //���뷿��
        CCMsg_FIVEINROW_SM_ENTERROOM_FAIL,  //�ظ�
        CCMsg_FIVEINROW_SM_ENTERROOM_READYHALL,//���뷿��ɹ����׼������������
        CCMsg_FIVEINROW_CM_LEAVEROOM,   //�뿪����
        CCMsg_FIVEINROW_SM_LEAVEROOM,   //�ظ�
        CCMsg_FIVEINROW_SM_AFTERENTERROOM,  //����Ҽ��뷿��ɹ�
        CCMsg_FIVEINROW_CM_SETSTAKECOIN,    //�������öĽ�
        CCMsg_FIVEINROW_SM_SETSTAKECOIN,    //�ظ�
        CCMsg_FIVEINROW_CM_PLAYERREADY,     //��ҵ��׼����ť
        CCMsg_FIVEINROW_SM_PLAYERREADY,     //�ظ�
        CCMsg_FIVEINROW_CM_PLAYERPRESS,     //�������
        CCMsg_FIVEINROW_SM_PLAYERPRESS,     //�ظ�
        CCMsg_FIVEINROW_SM_GAMESTART,       //��Ϸ��ʼ
        CCMsg_FIVEINROW_SM_GAMEOVER,        //��Ϸ����
        CCMsg_FIVEINROW_SM_NOTENOUGHSTAKECOIN,// ��׼������ ������������Ǯ����
        CCMsg_FIVEINROW_CM_PLAYERSURRENDER, //���Ͷ��

        CCMsg_FIVEINROW_SM_WAITAPPLYPEACE,  //�������Ҫ�� ������ѯ�Է�ͬ��
        CCMsg_FIVEINROW_SM_ASKAPPLYPEACE,   //������ѯ����һ����� ���
        CCMsg_FIVEINROW_CM_ANSWERAPPLYPEACE,    //��һ����һش� �Ƿ�ͬ�� ���
        CCMsg_FIVEINROW_SM_BACKAPPLYPEACE,  //�ظ���������͵����

        CCMsg_FIVEINROW_SM_WAITMOVEBACK,    //���ϻ���Ҫ�� ������ѯ�Է�ͬ��
        CCMsg_FIVEINROW_SM_ASKBACKMOVE,     //ѯ����һ������ܲ��ܻ���
        CCMsg_FIVEINROW_CM_ANSWERBACKMOVE,  //��һ����һظ��ܲ��ܻ���
        CCMsg_FIVEINROW_SM_TELLANSWERBACK,  //������һ���˱��˵Ļش�
        CCMsg_FIVEINROW_CM_NICKOUTOTHER,    //��������T��
        CCMsg_FIVEINROW_SM_BACKNICKOUT,     //֪ͨ���������

        //�����˿���Ϣ�Ŀ�ʼ
        CCMsg_TEXASPOKER_BEGIN = 100600,
        CCMsg_TEXASPOKER_CM_LOGIN,
        CCMsg_TEXASPOKER_SM_LOGIN,
        CCMsg_TEXASPOKER_CM_CHOOSElEVEL,
        CCMsg_TEXASPOKER_SM_CHOOSElEVEL,
        CCMsg_TEXASPOKER_SM_ENTERROOM,          //�ɹ����뷿���ѷ������Ϣ������
        CCMsg_TEXASPOKER_SM_ENTERGAMESTATE,     //������״̬�ı��� ͬ�����ͻ���
        CCMsg_TEXASPOKER_SM_DEALPOKERSTOPUBLIC, //�������ķ�һ����
        CCMsg_TEXASPOKER_CM_APPLYSITORSTAND,    //����������»���վ��
        CCMsg_TEXASPOKER_SM_APPLYSITORSTAND,    //�ظ�
        CCMsg_TEXASPOKER_SM_ASKCALLORDOUBLE,    //ѯ������Ǹ�ע ���� ��ע ���Ƿ���
        CCMsg_TEXASPOKER_CM_ANSWERCALLORDOUBLE, //��һظ�
        CCMsg_TEXASPOKER_SM_ANSWERCALLORDOUBLE, //ͬ������ҵ� �ش��������
        CCMsg_TEXASPOKER_SM_PUBLISHALLPOKERTYPE,
        CCMsg_TEXASPOKER_SM_PUBLISHCOINPOND,
        CCMsg_TEXASPOKER_SM_SENDRESULTTOPLAYER,
        CCMsg_TEXASPOKER_SM_SITPLAYERLEAVEROOM, //��ҵ���
        CCMsg_TEXASPOKER_SM_FORCELETSTAND,      //������վ����

        //��������Ϣ�Ŀ�ʼ
        CCMsg_LANDLORDS_BEGIN = 100700,
        CCMsg_LANDLORDS_CM_LOGIN,
        CCMsg_LANDLORDS_SM_LOGIN,
        CCMsg_LANDLORDS_CM_CHOOSElEVEL,
        CCMsg_LANDLORDS_SM_CHOOSElEVEL,
        CCMsg_LANDLORDS_SM_ENTERROOM,           //�ɹ����뷿���ѷ������Ϣ������
        CCMsg_LANDLORDS_SM_ENTERGAMESTATE,      //������Ϸ״̬���ͻ���
        CCMsg_LANDLORDS_SM_BEGINDEALPOKER,      //��Ϸ��ʼ��ʱ����17���Ƹ��������
        CCMsg_LANDLORDS_SM_ASKBELORDS,          //����������ѯ������Ƿ�Ҫ����
        CCMsg_LANDLORDS_CM_ASKBELORDS,          //��һظ�
        CCMsg_LANDLORDS_SM_BELORDSFAILED,       //�е���ʧ��
        CCMsg_LANDLORDS_SM_PUBLISHBELORDS,      //ͬ������ҵĻش��������
        CCMsg_LANDLORDS_SM_PUBLISHLORDSPOKER,   //����������������
        CCMsg_LANDLORDS_SM_ASKDEALPOKER,        //ѯ�ʳ���
        CCMsg_LANDLORDS_CM_ASKDEALPOKER,        //��һظ�����
        CCMsg_LANDLORDS_SM_DEALPOKERFAILED,     //��ҳ���ʧ��
        CCMsg_LANDLORDS_SM_PUBLISHDEALPOKER,    //��������ҳ��ƵĽ��
        CCMsg_LANDLORDS_SM_PUBLISHRESULT,   //ͬ��������ͻ���
        CCMsg_LANDLORDS_CM_ENTERMATCH,      //����ƥ��
        CCMsg_LANDLORDS_SM_ENTERMATCH,      //����
        CCMsg_LANDLORDS_CM_CANCLEMATCH,     //ȡ��ƥ��
        CCMsg_LANDLORDS_SM_CANCLEMATCH,     //����
        CCMsg_LANDLORDS_SM_RESTART,         //û��Ҫ�������¿�ʼ
        CCMsg_LANDLORDS_CM_EMOTION,         //�ͻ��˷�����
        CCMsg_LANDLORDS_SM_EMOTION,         //����
        CCMsg_LANDLORDS_CM_APPLYLEAVEROOM,      //��������뿪����
        CCMsg_LANDLORDS_SM_APPLYLEAVEROOM,      //�ظ�
        CCMsg_LANDLORDS_SM_MIDDLEENTERROOM,		//��;����
        CCMsg_LANDLORDS_SM_PLAYERDISORRECONNECT,//��ҵ��߻�����������
        CCMsg_LANDLORDS_SM_AFTERONLOOKERENTER,	//Χ�۵���ҽ��뷿��
        CCMsg_LANDLORDS_CM_LEAVEONLOOKERROOM,				//����뿪Χ�۵ķ���

        //����ţţ��Ϣ�Ŀ�ʼ��2�ѵģ�
        CCMsg_BULLHUNDRED_BEGIN = 100800,
        CCMsg_BULLHUNDRED_CM_LOGIN,
        CCMsg_BULLHUNDRED_SM_LOGIN,
        CCMsg_BULLHUNDRED_CM_CHOOSElEVEL,
        CCMsg_BULLHUNDRED_SM_CHOOSElEVEL,
        CCMsg_BULLHUNDRED_SM_ENTERROOM,     //���뷿��
        CCMsg_BULLHUNDRED_SM_ROOMSTATE,     //ͬ������״̬���ͻ���
        CCMsg_BULLHUNDRED_SM_BOSSCHANGE,    //��ׯ�Ķ�ı�
        CCMsg_BULLHUNDRED_SM_BOSSDOWN,      //��ׯ
        CCMsg_BULLHUNDRED_CM_APPLYBEBOSS,
        CCMsg_BULLHUNDRED_SM_APPLYBEBOSS,
        CCMsg_BULLHUNDRED_CM_APPLYBOSSLIST,
        CCMsg_BULLHUNDRED_SM_APPLYBOSSLIST,
        CCMsg_BULLHUNDRED_CM_CHIPIN,
        CCMsg_BULLHUNDRED_SM_CHIPIN,
        CCMsg_BULLHUNDRED_SM_PUBLISHCHIPIN, //�������ע ͬ����Ϣ��������
        CCMsg_BULLHUNDRED_SM_DEALPOKER,     //����
        CCMsg_BULLHUNDRED_SM_PUBLISHRESULT, //ͬ��������ͻ���
        CCMsg_BULLHUNDRED_CM_APPLYSITVIP,
        CCMsg_BULLHUNDRED_SM_APPLYSITVIP,
        CCMsg_BULLHUNDRED_SM_FORCELETSTAND,
        CCMsg_BULLHUNDRED_CM_APPLYLEAVEROOM,        //��������뿪����
        CCMsg_BULLHUNDRED_SM_APPLYLEAVEROOM,		//�ظ�
        CCMsg_BULLHUNDRED_SM_PUBLISHROLENUM,		//ͬ��������������


        //ͨɱţţ��Ϣ�Ŀ�ʼ��5�ѵģ�
        CCMsg_BULLKILL_BEGIN = 100900,
        CCMsg_BULLKILL_CM_LOGIN,
        CCMsg_BULLKILL_SM_LOGIN,
        CCMsg_BULLKILL_CM_CHOOSElEVEL,
        CCMsg_BULLKILL_SM_CHOOSElEVEL,
        CCMsg_BULLKILL_SM_ENTERROOM,
        CCMsg_BULLKILL_SM_ROOMSTATE,        //ͬ������״̬���ͻ���
        CCMsg_BULLKILL_SM_BOSSCHANGE,   //��ׯ�Ķ�ı�
        CCMsg_BULLKILL_SM_BOSSDOWN,     //��ׯ
        CCMsg_BULLKILL_SM_MAKEFIRSTPOKER,   //��һ�����Ƶ�����˭
        CCMsg_BULLKILL_SM_PUBLISHPOKERS,    //��������
        CCMsg_BULLKILL_CM_APPLYBEBOSS,
        CCMsg_BULLKILL_SM_APPLYBEBOSS,
        CCMsg_BULLKILL_CM_APPLYBOSSLIST,
        CCMsg_BULLKILL_SM_APPLYBOSSLIST,
        CCMsg_BULLKILL_CM_CHIPIN,
        CCMsg_BULLKILL_SM_CHIPIN,
        CCMsg_BULLKILL_SM_PUBLISHCHIPIN,    //�������ע ͬ����Ϣ��������
        CCMsg_BULLKILL_CM_APPLYSITVIP,
        CCMsg_BULLKILL_SM_APPLYSITVIP,
        CCMsg_BULLKILL_SM_FORCELETSTAND,
        CCMsg_BULLKILL_SM_PUBLISHRESULT,    //ͬ��������ͻ���
        CCMsg_BULLKILL_CM_APPLYLEAVEROOM,       //��������뿪����
        CCMsg_BULLKILL_SM_APPLYLEAVEROOM,		//�ظ�
        CCMsg_BULLKILL_SM_PUBLISHROLENUM,       //ͬ���������

        //���~��Ϣ��
        CCMsg_FISHING_BEING = 101000,
        CCMsg_FISHING_CM_LOGIN,
        CCMsg_FISHING_SM_LOGIN,
        CCMsg_FISHING_CM_CHOOSElEVEL,
        CCMsg_FISHING_SM_CHOOSElEVEL,
        CCMsg_FISHING_SM_ENTERROOM,             //���뷿��ɹ�
        CCMsg_FISHING_SM_FISHBORN,              //�������
        CCMsg_FISHING_SM_FISHDEAD,              //��������
        CCMsg_FISHING_CM_APPLYFIRE,             //������뿪��
        CCMsg_FISHING_SM_BACKFIRE,              //
        CCMsg_FISHING_CM_FIRERESULT,            //�ͻ��˸��߷��������Ǵ���
        CCMsg_FISHING_SM_FIRETESULT,            //ͬ����������
        CCMsg_FISHING_CM_APPLYLEAVE,            //�����˳�
        CCMsg_FISHING_SM_BACKLEAVE,             //�ظ����뿪����
        CCMsg_FISHING_CM_APPLYCHANGEROOM,		//���뻻������
        CCMsg_FISHING_SM_OTHERPLAYERENTER,      //�����Ѿ����뷿�����
        CCMsg_FISHING_CM_CHANGECANNON,          //��Ҹı���̨
        CCMsg_FISHING_SM_CHANGECANNON,          //ͬ����������������
        CCMsg_FISHING_CM_CHANGECANNONLEVEL,     //���Ҫ�ı�ȼ�
        CCMsg_FISHING_SM_CHANGECANNONLEVEL,     //ͬ����������������
        CCMsg_FISHING_SM_UPDATEROOMSTATE,       //���·���״̬���ͻ���
        CCMsg_FISHING_CM_PLAYERBUGCANNON,       //������빺����̨	
        CCMsg_FISHING_SM_PLAYERBUGCANNON,       //�ظ�
        CCMsg_FISHING_CM_USEFISHINGSKILL,       //�������ʹ�ü���
        CCMsg_FISHING_SM_BACKUSEFISHINGSKILL,   //�ظ���������
        CCMsg_FISHING_SM_UPDATEUSEFISHINGSKILL, //ͬ����������������������
        CCMsg_FISHING_CM_TRACECHANGETARGET,     //׷�ٵļ��ܸı�Ŀ��
        CCMsg_FISHING_SM_TRACECHANGETARGET,		//ͬ����������
        CCMsg_FISHING_SM_TRACESKILLTIMEOVER,    //׷�ٵļ���ʱ�����
        CCMsg_FISHING_SM_KICKOUTROOM,			//һ��ʱ�䲻������޳�����
        CCMsg_FISHING_SM_FIREFAILED,			//����ʧ��
        CCMsg_FISHING_CM_APPLYCORNUCOPIA,       //��ȡ�۱���Ľ���
        CCMsg_FISHING_SM_APPLYCORNUCOPIA,       //���
        CCMsg_FISHING_CM_APPLYSEALREWORD,       //��ȡ�����Ľ���
        CCMsg_FISHING_SM_APPLYSEALREWORD,		//���

        //��ׯţţ
        CCMsg_BULLHAPPY_BEING = 101100,
        CCMsg_BULLHAPPY_CM_LOGIN,
        CCMsg_BULLHAPPY_SM_LOGIN,
        CCMsg_BULLHAPPY_CM_CHOOSElEVEL,
        CCMsg_BULLHAPPY_SM_CHOOSElEVEL,
        CCMsg_BULLHAPPY_SM_OTHERENTERROOM,
        CCMsg_BULLHAPPY_SM_ENTERROOM,
        CCMsg_BULLHAPPY_SM_TIMECOUNT,
        CCMsg_BULLHAPPY_SM_PUBLISHPOKERS,
        CCMsg_BULLHAPPY_CM_DEALBOSS,
        CCMsg_BULLHAPPY_SM_DEALBOSS,
        CCMsg_BULLHAPPY_CM_CHIPIN,
        CCmsg_BULLHAPPY_SM_CHIPIN,
        CCmsg_BULLHAPPY_CM_CACULATE,
        CCmsg_BULLHAPPY_SM_CACULATE,
        CCmsg_BULLHAPPY_SM_OPENPOKERS,
        CCmsg_BULLHAPPY_SM_GAMERESULTS,
        CCMsg_BULLHAPPY_SM_RESULT,

        //�齫
        CCMsg_MAHJONG_BEING = 101200,
        CCMsg_MAHJONG_CM_LOGIN,
        CCMsg_MAHJONG_SM_LOGIN,
        CCMsg_MAHJONG_CM_CHOOSElEVEL,
        CCMsg_MAHJONG_SM_CHOOSElEVEL,
        CCMsg_MAHJONG_SM_ENTERROOM,             //���뷿��ɹ�
        CCMsg_MAHJONG_SM_ROOMSTATE,     //ͬ������״̬���ͻ���
        CCMsg_MAHJONG_SM_ASKREADY,      //�����������׼��
        CCMsg_MAHJONG_CM_ANSWERREADY,   //��һظ�׼��
        CCMsg_MAHJONG_SM_UPDATEREADY,   //�����׼���õ���Ϣ֪ͨ������
        CCMsg_MAHJONG_SM_DEALMJBEGIN,   //��ʼ��ʱ��ÿ��13����
        CCMsg_MAHJONG_CM_CHANGEPOKERS,  //��һ���
        CCMsg_MAHJONG_SM_UPDATECHANGEPOKERS,    //�������д��˻�������
        CCMsg_MAHJONG_CM_MAKELACK,          //��Ҷ�ȱ
        CCMsg_MAHJONG_SM_UPDATEMAKELACK,    //���������˶�ȱ
        CCMsg_MAHJONG_CM_PLAYERDEALMJPOKER, //��ҳ���
        CCMsg_MAHJONG_SM_BACKDEALMJPOKER,   //�ظ��������
        CCMsg_MAHJONG_SM_UPDATEDEALPOKER,   //ͬ�����Ƴ�ȥ
        CCMsg_MAHJONG_SM_FIRSTASKBANKERDEAL,//����ȱ֮�� ����ׯ�������ȳ���
        CCMsg_MAHJONG_CM_ANSWERDOING,       //��һظ� �� �� ��
        CCMsg_MAHJONG_SM_ANSWERDOING,       //�ظ�����
        CCMsg_MAHJONG_SM_UPDATEDOING,       //ͬ����ȥ
        CCMsg_MAHJONG_SM_GETPOKERASKDEAL,   //��һ���Ƹ�����Ҳ���������
        CCMsg_MAHJONG_SM_PLAYERHUPOKER,     //��Һ���
        CCMsg_MAHJONG_SM_PUBLISHRESULT,		//ͬ����Ϸ���
        CCMsg_MAHJONG_SM_OTHERENTER,        //���������� ���˼��뷿��
        CCMsg_MAHJONG_CM_APPLYLEAVE,        //�����˳�
        CCMsg_MAHJONG_SM_BACKLEAVE,			//�ظ����뿪����
        CCMsg_MAHJONG_SM_TRUSTCHANGEPOKERS,     //�йܻ���
        CCMsg_MAHJONG_SM_ENTERTRUSTSTATE,       //֪ͨ�ͻ��˽����й�״̬
        CCMsg_MAHJONG_CM_CANCLETRUSTSTATE,      //���ȡ���й�״̬
        CCMsg_MAHJONG_SM_MIDDLEENTERROOM,       //�����;����
        CCMsg_MAHJONG_SM_AFTERONLOOKERENTER,    //Χ�۵���ҽ��뷿��
        CCMsg_MAHJONG_CM_LEAVEONLOOKERROOM,             //����뿪Χ�۵ķ���
        CCMsg_MAHJONG_SM_AFTERQIANGGANGHUCUTCOIN,//WaitQiangGangHu״̬�� �����Ҳ����� ��������Ǯ�ĺ���
        CCMsg_MAHJONG_SM_LIUJUINFO,         //�˻ظյ�˰ ���� �黨��
        CCMsg_MAHJONG_SM_HUJIAOZHUANYI,         //����ת��

        //�γ��齫
        CCMsg_YCMAHJONG_BEING = 101400,
        CCMsg_YCMAHJONG_CM_LOGIN,
        CCMsg_YCMAHJONG_SM_LOGIN,
        CCMsg_YCMAHJONG_CM_CHOOSElEVEL,
        CCMsg_YCMAHJONG_SM_CHOOSElEVEL,
        CCMsg_YCMAHJONG_SM_ENTERROOM,               //���뷿��ɹ�
        CCMsg_YCMAHJONG_SM_ROOMSTATE,       //ͬ������״̬���ͻ���
        CCMsg_YCMAHJONG_SM_ASKREADY,        //�����������׼��
        CCMsg_YCMAHJONG_CM_ANSWERREADY, //��һظ�׼��
        CCMsg_YCMAHJONG_SM_UPDATEREADY, //�����׼���õ���Ϣ֪ͨ������
        CCMsg_YCMAHJONG_SM_DEALMJBEGIN, //��ʼ��ʱ��ÿ��13����
        CCMsg_YCMAHJONG_CM_PLAYERDEALMJPOKER,   //��ҳ���
        CCMsg_YCMAHJONG_SM_BACKDEALMJPOKER, //�ظ��������
        CCMsg_YCMAHJONG_SM_UPDATEDEALPOKER, //ͬ�����Ƴ�ȥ
        CCMsg_YCMAHJONG_SM_FIRSTASKBANKERDEAL,//����ȱ֮�� ����ׯ�������ȳ���
        CCMsg_YCMAHJONG_CM_ANSWERDOING,     //��һظ� �� �� ��
        CCMsg_YCMAHJONG_SM_ANSWERDOING,     //�ظ�����
        CCMsg_YCMAHJONG_SM_UPDATEDOING,     //ͬ����ȥ
        CCMsg_YCMAHJONG_SM_GETPOKERASKDEAL, //��һ���Ƹ�����Ҳ���������
        CCMsg_YCMAHJONG_SM_PLAYERHUPOKER,       //��Һ���
        CCMsg_YCMAHJONG_SM_PUBLISHRESULT,       //ͬ����Ϸ���
        CCMsg_YCMAHJONG_SM_OTHERENTER,      //���������� ���˼��뷿��
        CCMsg_YCMAHJONG_CM_APPLYLEAVE,          //�����˳�
        CCMsg_YCMAHJONG_SM_BACKLEAVE,               //�ظ����뿪����
        CCMsg_YCMAHJONG_SM_TRUSTCHANGEPOKERS,       //�йܻ���
        CCMsg_YCMAHJONG_SM_ENTERTRUSTSTATE,     //֪ͨ�ͻ��˽����й�״̬
        CCMsg_YCMAHJONG_CM_CANCLETRUSTSTATE,        //���ȡ���й�״̬
        CCMsg_YCMAHJONG_SM_MIDDLEENTERROOM,     //�����;����
        CCMsg_YCMAHJONG_SM_AFTERONLOOKERENTER,  //Χ�۵���ҽ��뷿��
        CCMsg_YCMAHJONG_CM_LEAVEONLOOKERROOM,               //����뿪Χ�۵ķ���
        CCMsg_YCMAHJONG_SM_UPDATEPOKERSAFTERBUHUA,	//���������� ��ͬ��һ��
        CCMsg_YCMAHJONG_CM_PLAYERAPPLYTINGORFEI,    //������������߷���
        CCMsg_YCMAHJONG_SM_BACKPLAYERTINGORFEI,     //�ظ�
        CCMsg_YCMAHJONG_SM_UPDATEPLAYERTINGORFEI,	//ͬ����ȥ

        //�走
        CCMsg_GUANDAN_BEING = 101300,
        CCMsg_GUANDAN_CM_LOGIN,
        CCMsg_GUANDAN_SM_LOGIN,
        CCMsg_GUANDAN_CM_CHOOSELEVEL,
        CCMsg_GUANDAN_SM_CHOOSELEVEL,
        CCMsg_GUANDAN_SM_ENTERROOM,
        CCMsg_GUANDAN_SM_ROOMSTATE,     //ͬ������״̬���ͻ���
        CCMsg_GUANDAN_SM_ASKREADY,      //ѯ���Ƿ�׼��
        CCMsg_GUANDAN_CM_ANSWERREADY,   //�ظ�׼����
        CCMsg_GUANDAN_SM_DEALMJBEGIN,   //����
        CCMsg_GUANDAN_CM_SUBMITPOKER,   //����Ϲ�
        CCMsg_GUANDAN_SM_SUBMITPOKER,   //�ظ�
        CCMsg_GUANDAN_CM_RETURNPOKER,   //��һ���
        CCMsg_GUANDAN_SM_RETURNPOKER,   //�ظ�
        CCMsg_GUANDAN_CM_OUTPOKERS,     //��ҳ���
        CCMsg_GUANDAN_SM_OUTPOKERS,     //ʧ���˲Żָ�����ظ�
        CCMsg_GUANDAN_SM_PUBLISHOUTPOKER,//��ҳ���ͬ����ȥ
        CCMsg_GUANDAN_SM_PUBLISHRESULT,//ͬ�� ���
        CCMsg_GUANDAN_SM_LETOUTPOKER,	//֪ͨ�ͻ����������ҳ���
        CCMsg_GUANDAN_SM_FRIENDPOKERS,  //һ����ҽ����Ѷ��ѵ�ǰ����ͬ������
        CCMsg_GUANDAN_CM_APPLYLEAVE,            //�����˳�
        CCMsg_GUANDAN_SM_BACKLEAVE,             //�ظ����뿪����
        CCMsg_GUANDAN_SM_AFTERALLSUBMIT,    //��Ҷ��Ϲ�����֮��
        CCMsg_GUANDAN_SM_AFTERALLRETURN,    //��Ҷ�������
        CCMsg_GUANDAN_CM_EMOTION,           //�ͻ��˷�����
        CCMsg_GUANDAN_SM_EMOTION,           //����
        CCMsg_GUANDAN_SM_MIDDLEENTERROOM,   //��;����
        CCMsg_GUANDAN_CM_AGAINGAME,         //�����������һ�Σ�ƥ�䳡��
        CCMsg_GUANDAN_SM_AGAINGAME,         //�ظ�
        CCMsg_GUANDAN_CM_ENTERMATCH,        //����ƥ��
        CCMsg_GUANDAN_SM_ENTERMATCH,        //����
        CCMsg_GUANDAN_CM_CANCLEMATCH,       //ȡ��ƥ��
        CCMsg_GUANDAN_SM_CANCLEMATCH,		//����
        CCMsg_GUANDAN_SM_AFTERONLOOKERENTER,	//Χ�۵���ҽ��뷿��
        CCMsg_GUANDAN_CM_LEAVEONLOOKERROOM,             //����뿪Χ�۵ķ���

        //�����齫
        CCMsg_CZMAHJONG_BEING = 101500,
        CCMsg_CZMAHJONG_CM_LOGIN,
        CCMsg_CZMAHJONG_SM_LOGIN,
        CCMsg_CZMAHJONG_CM_CHOOSElEVEL,
        CCMsg_CZMAHJONG_SM_CHOOSElEVEL,
        CCMsg_CZMAHJONG_SM_ENTERROOM,               //���뷿��ɹ�
        CCMsg_CZMAHJONG_SM_ROOMSTATE,               //ͬ������״̬���ͻ���
        CCMsg_CZMAHJONG_SM_ASKREADY,                //�����������׼��
        CCMsg_CZMAHJONG_CM_ANSWERREADY,             //��һظ�׼��
        CCMsg_CZMAHJONG_SM_UPDATEREADY,             //�����׼���õ���Ϣ֪ͨ������
        CCMsg_CZMAHJONG_SM_DEALMJBEGIN,             //��ʼ��ʱ��ÿ��13����
        CCMsg_CZMAHJONG_CM_PLAYERDEALMJPOKER,       //��ҳ���
        CCMsg_CZMAHJONG_SM_BACKDEALMJPOKER,         //�ظ��������
        CCMsg_CZMAHJONG_SM_UPDATEDEALPOKER,         //ͬ�����Ƴ�ȥ
        CCMsg_CZMAHJONG_SM_FIRSTASKBANKERDEAL,      //����ȱ֮�� ����ׯ�������ȳ���
        CCMsg_CZMAHJONG_CM_ANSWERDOING,             //��һظ� �� �� ��
        CCMsg_CZMAHJONG_SM_ANSWERDOING,             //�ظ�����
        CCMsg_CZMAHJONG_SM_UPDATEDOING,             //ͬ����ȥ
        CCMsg_CZMAHJONG_SM_GETPOKERASKDEAL,         //��һ���Ƹ�����Ҳ���������
        CCMsg_CZMAHJONG_SM_PLAYERHUPOKER,           //��Һ���
        CCMsg_CZMAHJONG_SM_PUBLISHRESULT,           //ͬ����Ϸ���
        CCMsg_CZMAHJONG_SM_OTHERENTER,              //���������� ���˼��뷿��
        CCMsg_CZMAHJONG_CM_APPLYLEAVE,              //�����˳�
        CCMsg_CZMAHJONG_SM_BACKLEAVE,               //�ظ����뿪����
        CCMsg_CZMAHJONG_SM_TRUSTCHANGEPOKERS,       //�йܻ���
        CCMsg_CZMAHJONG_SM_ENTERTRUSTSTATE,         //֪ͨ�ͻ��˽����й�״̬
        CCMsg_CZMAHJONG_CM_CANCLETRUSTSTATE,        //���ȡ���й�״̬
        CCMsg_CZMAHJONG_SM_MIDDLEENTERROOM,         //�����;����
        CCMsg_CZMAHJONG_SM_AFTERONLOOKERENTER,      //Χ�۵���ҽ��뷿��
        CCMsg_CZMAHJONG_CM_LEAVEONLOOKERROOM,       //����뿪Χ�۵ķ���
        CCMsg_CZMAHJONG_SM_UPDATEPOKERSAFTERBUHUA,  //���������� ��ͬ��һ��

        //����ת��
        CCMsg_TURNTABLE_BEING = 101600,
        CCMsg_TURNTABLE_CM_LOGIN,
        CCMsg_TURNTABLE_SM_LOGIN,
        CCMsg_TURNTABLE_CM_CHOOSElEVEL,
        CCMsg_TURNTABLE_SM_CHOOSElEVEL,
        CCMsg_TURNTABLE_SM_ENTERROOM,				//���뷿��ɹ�
        CCMsg_TURNTABLE_CM_APPLYLEAVE,              //�����˳�
        CCMsg_TURNTABLE_SM_BACKLEAVE,               //�ظ����뿪����
        CCMsg_TURNTABLE_LotteryDraw,                //�齱
        CCMsg_TURNTABLE_Bonus,                      //�����н�

        //����
        CCMsg_GOUJI_BEING = 101700,
        CCMsg_GOUJI_CM_LOGIN,
        CCMsg_GOUJI_SM_LOGIN,
        CCMsg_GOUJI_CM_CHOOSElEVEL,
        CCMsg_GOUJI_SM_CHOOSElEVEL,
        CCMsg_GOUJI_SM_ENTERROOM,               //���뷿��ɹ�
        CCMsg_GOUJI_SM_ROOMSTATE,               //ͬ������״̬���ͻ���
        CCMsg_GOUJI_SM_ASKREADY,                //�����������׼��
        CCMsg_GOUJI_CM_ANSWERREADY,             //��һظ�׼��
        CCMsg_GOUJI_SM_UPDATEREADY,             //�����׼���õ���Ϣ֪ͨ������
        CCMsg_GOUJI_SM_DEALMJBEGIN,             //��ʼ����
        CCMsg_GOUJI_CM_PLAYERDEALMJPOKER,       //��ҳ���
        CCMsg_GOUJI_SM_BACKDEALMJPOKER,         //�ظ��������
        CCMsg_GOUJI_SM_UPDATEDEALPOKER,         //ͬ������ͬ��
        CCMsg_GOUJI_CM_ANSWERDOING,             //��һظ�
        CCMsg_GOUJI_SM_ANSWERDOING,             //�ظ�����
        CCMsg_GOUJI_SM_UPDATEDOING,             //ͬ����ȥ
        CCMsg_GOUJI_SM_ASKDEAL,                 //����
        CCMsg_GOUJI_SM_PUBLISHASKDEAL,          //ͬ������
        CCMsg_GOUJI_SM_PUBLISHRESULT,           //ͬ����Ϸ���
        CCMsg_GOUJI_SM_OTHERENTER,              //���������� ���˼��뷿��
        CCMsg_GOUJI_CM_APPLYLEAVE,              //�����˳�
        CCMsg_GOUJI_SM_BACKLEAVE,               //�ظ����뿪����
        CCMsg_GOUJI_SM_TRUSTCHANGEPOKERS,       //�йܻ���
        CCMsg_GOUJI_SM_ENTERTRUSTSTATE,         //֪ͨ�ͻ��˽����й�״̬
        CCMsg_GOUJI_CM_CANCLETRUSTSTATE,        //���ȡ���й�״̬
        CCMsg_GOUJI_SM_MIDDLEENTERROOM,         //�����;����
        CCMsg_GOUJI_SM_AFTERONLOOKERENTER,      //Χ�۵���ҽ��뷿��
        CCMsg_GOUJI_CM_LEAVEONLOOKERROOM,       //����뿪Χ�۵ķ���
        CCMsg_GOUJI_CM_CHANGEFRIEND,            //������һ�����ѵ���
        CCMsg_GOUJI_SM_FRIENDPOKERS,            //ͬ�����ѵ���
        CCMsg_GOUJI_SM_YAOTOUINFO,              //֪ͨҪͷ���
        CCMsg_GOUJI_SM_XUANDIANINFO,            //֪ͨ�������
        CCMsg_GOUJI_SM_CLEARRANGPAI,            //֪ͨȡ������
        CCMsg_GOUJI_SM_KAIDIAN,					//ͬ���������
        CCMsg_GOUJI_SM_4HULUANCHAN,				//֪ͨ�����Ļ��Ҳ�
        CCMsg_GOUJI_SM_BIE3,                    //֪ͨ��3

        //�����齫
        CCMsg_HONGMAHJONG_BEING = 101800,
        CCMsg_HONGMAHJONG_CM_LOGIN,
        CCMsg_HONGMAHJONG_SM_LOGIN,
        CCMsg_HONGMAHJONG_CM_CHOOSElEVEL,
        CCMsg_HONGMAHJONG_SM_CHOOSElEVEL,
        CCMsg_HONGMAHJONG_SM_ENTERROOM,             //���뷿��ɹ�
        CCMsg_HONGMAHJONG_SM_ROOMSTATE,             //ͬ������״̬���ͻ���
        CCMsg_HONGMAHJONG_SM_ASKREADY,              //�����������׼��
        CCMsg_HONGMAHJONG_CM_ANSWERREADY,           //��һظ�׼��
        CCMsg_HONGMAHJONG_SM_UPDATEREADY,           //�����׼���õ���Ϣ֪ͨ������
        CCMsg_HONGMAHJONG_SM_DEALMJBEGIN,           //��ʼ��ʱ��ÿ��13����
        CCMsg_HONGMAHJONG_CM_PLAYERDEALMJPOKER,     //��ҳ���
        CCMsg_HONGMAHJONG_SM_BACKDEALMJPOKER,       //�ظ��������
        CCMsg_HONGMAHJONG_SM_UPDATEDEALPOKER,       //ͬ�����Ƴ�ȥ
        CCMsg_HONGMAHJONG_SM_FIRSTASKBANKERDEAL,    //����ȱ֮�� ����ׯ�������ȳ���
        CCMsg_HONGMAHJONG_CM_ANSWERDOING,           //��һظ� �� �� ��
        CCMsg_HONGMAHJONG_SM_ANSWERDOING,           //�ظ�����
        CCMsg_HONGMAHJONG_SM_UPDATEDOING,           //ͬ����ȥ
        CCMsg_HONGMAHJONG_SM_GETPOKERASKDEAL,       //��һ���Ƹ�����Ҳ���������
        CCMsg_HONGMAHJONG_SM_PLAYERHUPOKER,         //��Һ���
        CCMsg_HONGMAHJONG_SM_PUBLISHRESULT,         //ͬ����Ϸ���
        CCMsg_HONGMAHJONG_SM_OTHERENTER,            //���������� ���˼��뷿��
        CCMsg_HONGMAHJONG_CM_APPLYLEAVE,            //�����˳�
        CCMsg_HONGMAHJONG_SM_BACKLEAVE,             //�ظ����뿪����
        CCMsg_HONGMAHJONG_SM_TRUSTCHANGEPOKERS,     //�йܻ���
        CCMsg_HONGMAHJONG_SM_ENTERTRUSTSTATE,       //֪ͨ�ͻ��˽����й�״̬
        CCMsg_HONGMAHJONG_CM_CANCLETRUSTSTATE,      //���ȡ���й�״̬
        CCMsg_HONGMAHJONG_SM_MIDDLEENTERROOM,       //�����;����
        CCMsg_HONGMAHJONG_SM_AFTERONLOOKERENTER,    //Χ�۵���ҽ��뷿��
        CCMsg_HONGMAHJONG_CM_LEAVEONLOOKERROOM,		//����뿪Χ�۵ķ���
        CCMsg_HONGMAHJONG_SM_AFTERQIANGGANGHUCUTCOIN,//WaitQiangGangHu״̬�� �����Ҳ����� ��������Ǯ�ĺ���

        //������
        CCMsg_ANSWER_BEING = 101900,
        CCMsg_ANSWER_CM_LOGIN,
        CCMsg_ANSWER_SM_LOGIN,
        CCMsg_ANSWER_CM_CHOOSElEVEL,
        CCMsg_ANSWER_SM_CHOOSElEVEL,
        CCMsg_ANSWER_SM_ENTERROOM,              //���뷿��ɹ�
        CCMsg_ANSWER_SM_ROOMSTATE,              //ͬ������״̬���ͻ���
        CCMsg_ANSWER_SM_ASKREADY,               //�����������׼��
        CCMsg_ANSWER_CM_ANSWERREADY,            //��һظ�׼��
        CCMsg_ANSWER_SM_UPDATEREADY,            //�����׼���õ���Ϣ֪ͨ������
        CCMsg_ANSWER_SM_DEALMJBEGIN,            //��ʼ��ʱ��ÿ��13����
        CCMsg_ANSWER_CM_PLAYERDEALMJPOKER,      //��ҳ���
        CCMsg_ANSWER_SM_BACKDEALMJPOKER,        //�ظ��������
        CCMsg_ANSWER_SM_UPDATEDEALPOKER,        //ͬ�����Ƴ�ȥ
        CCMsg_ANSWER_SM_FIRSTASKBANKERDEAL,     //����ȱ֮�� ����ׯ�������ȳ���
        CCMsg_ANSWER_CM_ANSWERDOING,            //��һظ� �� �� ��
        CCMsg_ANSWER_SM_ANSWERDOING,            //�ظ�����
        CCMsg_ANSWER_SM_UPDATEDOING,            //ͬ����ȥ
        CCMsg_ANSWER_SM_GETPOKERASKDEAL,        //��һ���Ƹ�����Ҳ���������
        CCMsg_ANSWER_SM_PLAYERHUPOKER,          //��Һ���
        CCMsg_ANSWER_SM_PUBLISHRESULT,          //ͬ����Ϸ���
        CCMsg_ANSWER_SM_OTHERENTER,             //���������� ���˼��뷿��
        CCMsg_ANSWER_CM_APPLYLEAVE,             //�����˳�
        CCMsg_ANSWER_SM_BACKLEAVE,              //�ظ����뿪����
        CCMsg_ANSWER_SM_TRUSTCHANGEPOKERS,      //�йܻ���
        CCMsg_ANSWER_SM_ENTERTRUSTSTATE,        //֪ͨ�ͻ��˽����й�״̬
        CCMsg_ANSWER_CM_CANCLETRUSTSTATE,       //���ȡ���й�״̬
        CCMsg_ANSWER_SM_MIDDLEENTERROOM,        //�����;����
        CCMsg_ANSWER_SM_AFTERONLOOKERENTER,     //Χ�۵���ҽ��뷿��
        CCMsg_ANSWER_CM_LEAVEONLOOKERROOM,      //����뿪Χ�۵ķ���

        ///����
		CCMsg_CChess_BEING = 102000,
        CCMsg_CChess_CM_LOGIN,
        CCMsg_CChess_SM_LOGIN,
        CCMsg_CChess_CM_CHOOSElEVEL,
        CCMsg_CChess_SM_CHOOSElEVEL,
        CCMsg_CChess_SM_ENTERROOM,              //���뷿��ɹ�
        CCMsg_CChess_SM_ROOMSTATE,              //ͬ������״̬���ͻ���
        CCMsg_CChess_SM_ASKREADY,               //�����������׼��
        CCMsg_CChess_CM_ANSWERREADY,            //��һظ�׼��
        CCMsg_CChess_SM_UPDATEREADY,            //�����׼���õ���Ϣ֪ͨ������
        CCMsg_CChess_SM_DEALBEGIN,              //��ʼ�ں���
        CCMsg_CChess_CM_ANSWERDOING,            //�������
        CCMsg_CChess_SM_ANSWERDOING,            //�ظ�
        CCMsg_CChess_SM_ASKDEAL,                //�ֵ������
        CCMsg_CChess_WithDraw,                  //����
        CCMsg_CChess_RequestDraw,               //���
        CCMsg_CChess_RequestDrawResult,         //��ͽ��
        CCMsg_CChess_GiveUp,					//Ͷ��
        CCMsg_CChess_SM_PUBLISHRESULT,          //ͬ����Ϸ���
        CCMsg_CChess_SM_OTHERENTER,             //���������� ���˼��뷿��
        CCMsg_CChess_CM_APPLYLEAVE,             //�����˳�
        CCMsg_CChess_SM_BACKLEAVE,              //�ظ����뿪����
        CCMsg_CChess_SM_ENTERTRUSTSTATE,        //֪ͨ�ͻ��˽����й�״̬
        CCMsg_CChess_CM_CANCLETRUSTSTATE,       //���ȡ���й�״̬
        CCMsg_CChess_SM_MIDDLEENTERROOM,        //�����;����
        CCMsg_CChess_SM_AFTERONLOOKERENTER,     //Χ�۵���ҽ��뷿��
        CCMsg_CChess_CM_LEAVEONLOOKERROOM,		//����뿪Χ�۵ķ���

        //���ֲ���Ϣ�Ŀ�ʼ
        CrazyCityMsg_CLUB_BEGIN = 200000,
    }

    //������Ϸ������Ϣ
    enum CarportMsg_enum
    {
        CarportMsg_Begin = EMSG_ENUM.CrazyCityMsg_CARPORT_BEGIN,
        CarportMsg_CM_LOGIN,                            //�ͻ��˵�½
        CarportMsg_SM_LOGIN,                            //����������
        CarportMsg_CM_CHOOSELEVEL,                      //ѡ��ȼ�
        CarportMsg_SM_CHOOSELEVEL,                      //�ظ��ͻ���
        CarportMsg_CM_CHIPCAR,                          //��ע
        CarportMsg_SM_CHIPCAR,                          //�ظ���ע
        CarportMsg_CM_APPLYBOSS,                        //���������ׯ
        CarportMsg_SM_APPLYBOSS,                        //�ظ����������ׯ
        CarportMsg_SM_BOSSCHANGE,                       //��ׯ��Ҹı�
        CarportMsg_SM_GAMESULET,                        //���
        CarportMsg_SM_SORTDATA,                         //������
        CarportMsg_CM_CANCLEAPPLYBOSS,                  //ȡ��������ׯ
        CarportMsg_SM_CANCLEAPPLYBOSS,                  //�ظ�
        CarportMsg_CM_APPLYDOWNBOSS,                    //��ׯ����������ׯ
        CarportMsg_SM_APPLYDOWNBOSS,                    //�ظ�
        CarportMsg_CM_CANCLEAPPLYDOWNBOSS,              //���ȡ��������ׯ
        CarportMsg_SM_CANCLEAPPLYDOWNBOSS,              //�ظ�
        CarportMsg_CM_APPLYBOSSLIST,                    //���������ׯ���б�
        CarportMsg_SM_APPLYBOSSLIST,                    //�ظ�
        CarportMsg_SM_CURTABLEDATATONEWIN,              //���͵�ǰ���������ݸ�������
        CarportMsg_SM_HISTROYCARDATA,                   //��ʷ����
        CarportMsg_SM_BEGINCHIP,                        //��ʼ��ע
        CarportMsg_SM_KNCKOUTROOM,                      //T������
        CarportMsg_CM_LEAVEROOM,                        //����뿪����
        CarportMsg_SM_LEAVEROOM,

        CarportMsg_Max

    }

    // ��Ϸ״̬��ö��
    public enum CarPortGameState_enum
    {
        CarPortState_Init = 0,

        CarPortState_WaitBoss = 1,      //�ȴ�������ׯ
        CarPortState_ChipIn = 2,        //��ע״̬
        CarPortState_Roulette = 3,      //������ת״̬
        CarPortState_OverWait = 4,      //һ�ֽ�����Ҫ�ȴ�һ���

        CarPortState_Max
    }

    // ���ֲ�2����Ϣ
    public enum ClubSecondMsg
    {
        ClubSecondInit = EMSG_ENUM.CrazyCityMsg_CLUB_BEGIN,

        CM_ClubScondCreate,                 //�������ֲ�
        SM_ClubScondCreate,
        CM_ClubSecondExpel,                 //�߳�
        SM_ClubSecondExpel,
        CM_ClubSecondJoin,                      //������ֲ�
        SM_ClubSecondJoin,
        CM_ClubSecondLevelUp,                   //���ֲ�����
        SM_ClubSecondLevelUp,
        CM_ClubSecondGive,                      //����
        SM_ClubSecondGive,
        CM_ClubSecondBindingPhone,              //���ֻ�
        SM_ClubSecondBindingPhone,
        CM_ClubSecondCheckPhone,                //��֤�ֻ�
        SM_ClubSecondCheckPhone,
        CM_ClubSecondChangeJoinCondition,       //�޸ļ�������
        SM_ClubSecondChangeJoinCondition,
        CM_ClubSecondExpelOneKey,               //һ���߳�
        SM_ClubSecondExpelOneKey,
        CM_ClubSecondJoinOneKey,                //һ������
        SM_ClubSecondJoinOneKey,
        CM_ClubSecondInfo,                  //���ֲ�������Ϣ
        SM_ClubSecondInfo,
        CM_ClubBreak,                           //��ɢ���ֲ�
        SM_ClubBreak,
        CM_ExitClub,                            //�˳����ֲ�
        SM_ExitClub,
        CM_ClubSearch,                      //����
        SM_ClubSearch,
        CM_ClubChangeContent,                   //�޸Ĺ�������
        SM_ClubChangeContent,
        CM_ClubChangeActive,                    //�޸Ĺ����Ծ��
        SM_ClubChangeActive,
        CM_ClubChangeStep,                  //�޸Ĺ���ȼ�
        SM_ClubChangeStep,
        CM_ClubMemberLoginOrExit,               //��Ա������
        SM_ClubMemberLoginOrExit,
        CM_ClubMemberChangeNameOrIcon,      //��Ա�޸����ƺ�ͷ��	
        SM_ClubMemberChangeNameOrIcon,
        CM_ClubCreateRefreshList,               //�������ֲ�֪ͨ�������
        SM_ClubCreateRefreshList,
        CM_ClubBreakRefreshList,                //��ɢ���ֲ�֪ͨ�������
        SM_ClubBreakRefreshList,

        ClubSecondMax
    }

    //��������Ϸ������Ϣ
    public enum Diudiule_enum
    {
        DiudiuleMsg_Begin = EMSG_ENUM.CrazyCityMsg_DIUDIULE_BEGIN,
        DiudiuleMsg_CM_LOGIN,                           //�ͻ��˵�½
        DiudiuleMsg_SM_LOGIN,                           //����������
        DiudiuleMsg_CM_GAMELIMIT,                       //����
        DiudiuleMsg_SM_GAMELIMIT,                       //
        DiudiuleMsg_CM_REGION,                          //����ƥ��
        DiudiuleMsg_SM_REGION,
        DiudiuleMsg_SM_SITDOWN,                         //ƥ��ɹ�
        DiudiuleMsg_SM_GAMESTART,                       //��Ϸ��ʼ
        DiudiuleMsg_CM_CANCLEREGION,                    //ȡ��ƥ��
        DiudiuleMsg_SM_CANCLEREGION,
        DiudiuleMsg_CM_ACTION,                          //��ҳ���
        DiudiuleMsg_SM_ACTION,
        DiudiuleMsg_CM_GAMEEND,                         //
        DiudiuleMsg_SM_GAMEEND,                         //��Ϸ����
        DiudiuleMsg_CM_GAMEAUTO,                        //���ȡ���й�
        DiudiuleMsg_SM_GAMEAUTO,                        //�Ƿ��й�
        DiudiuleMsg_SM_GAMESCENE,                       //
        DiudiuleMsg_SM_RECONNECT,                       //�������ʿͻ����Ƿ�����
        DiudiuleMsg_CM_RECONNECT,                       //�ͻ��˻ظ�������
        DiudiuleMsg_CM_EMOTION,                         //����
        DiudiuleMsg_SM_EMOTION,
        DiudiuleMsg_CM_GAMESCENE,                       // �ͻ�����������
        DiudiuleMsg_SM_NOGAMESCENE,                     // ����Ҳ��ڷ����� ����Ҫͬ��

        DiudiuleMsg_Max

    }

    //����2����Ϣ
    public enum SlotSecondMsg
    {
        LabaMsg_Begin = EMSG_ENUM.CrazyCityMsg_LABA_BEGIN,
        LabaMsg_CM_LOGIN,                           //�ͻ��˵�½
        LabaMsg_SM_LOGIN,                           //����������
        LabaMsg_CM_CHOOSElEVEL,                     //ѡ��ȼ�����
        LabaMsg_SM_CHOOSElEVEL,
        LabaMsg_CM_GAMESTATE,                       //������Ϸ��ʼ
        LabaMsg_SM_GAMESTATE,
        LabaMsg_CM_DOUBLEREWORD,                    //����˫������
        LabaMsg_SM_DOUBLEREWORD,                    //�ظ�
        LabaMsg_CM_DRAWREWORD,                      //�������
        LabaMsg_SM_DRAWREWORD,                      //�ظ�
        LabaMsg_SM_KICKOUTROOM,                     //Ǯ����T��ȥ
        LabaMsg_CM_LEAVEROOM,
        LabaMsg_SM_LEAVEROOM,

        Laba_enum_Max
    }

    //ɭ����������Ϣ
    enum Forest_enum
    {
        ForestMsg_Begin = EMSG_ENUM.CrazyCityMsg_FOREST_BEGIN,
        ForestMsg_CM_LOGIN,                         //�ͻ��˵�½
        ForestMsg_SM_LOGIN,                         //����������
        ForestMsg_CM_CHOOSElEVEL,                   //ѡ��ȼ�����
        ForestMsg_SM_CHOOSElEVEL,
        ForestMsg_SM_GAMEBEGIN,                     //���������߿ͻ��� ���ID�Ƕ���
        ForestMsg_SM_GAMERESULT,                    //���������߿ͻ��˽��
        ForestMsg_CM_CHIPIN,                        //��ע
        ForestMsg_SM_CHIPIN,
        ForestMsg_SM_GAMECOUNT,                     //������������������߿ͻ���
        ForestMsg_SM_ROOMDATATONEWJOIN,             //���ͷ������ݸ��¼�������
        ForestMsg_SM_ROOMHISTROYTOJOIN,             //���ͷ�����ʷ���ݸ����
        ForestMsg_CM_LEAVEROOM,                     //����뿪����
        ForestMsg_SM_LEAVEROOM,                     //����

        Forest_enum_Max
    };

    enum ForestMode_Enum
    {
        ForestMode_Init = 0,
        //���� ����ɫ�����﷽�Ż�
        ForestMode_Normal,
        //����Ԫ �ö����������ɫ���ɻ�
        ForestMode_Three,
        //����ϲ ����ɫ�����ж�����ɻ�
        ForestMode_Four,
        //��ǹ ��ģʽ�£�ϵͳ�����������Σ�
        //ÿ�ο���Ϊ����ɫ�����Ҳ������ͨ�������
        ForestMode_GiveGun,
        // ��ģʽ�£�ϵͳ���Ȼ����һ�����ʣ�2-4����
        //Ȼ�󿪵���ɫ�͵�����񽱵ı�����ԭ�б��ʵĻ�����*����ı��ʣ���ׯ������Ч
        ForestMode_Flash,
        //�ʽ�ģʽ ��ģʽ�£�ϵͳ�ᵥ���������ɫ��
        //����ѹ�е�����ڻ�û����Ľ���֮�⣬Ѻע����ߵ�10�����
        //������в��е�ʮ����ȡ���еĵ�ʮ����ң�������ֶ����40%�Ĳʽ�ؽ�����
        //���ڿ���Ч���ϣ��в�����һ�δ��ý��������ߵı��ֲ�ͬ��
        //��˷���������ʱ��Ҫ��֪�ͻ��ˣ���Щ��һ���˲ʽ𣬴Ӷ��в�ͬ�ı���Ч����
        ForestMode_Handsel,
        //ϵͳӮǮģʽ
        ForestMode_SystemWin,

        ForestMode_Max,
    };

    //�������ʱ�� �����״̬
    enum FiveRoomState_Enum
    {
        FiveRoomState_Init = 0,
        FiveRoomState_WaitOther,    //���������� �ȴ������˼���
        FiveRoomState_Ready,        //�ȴ�˫��׼��
        FiveRoomState_GameOn,       //��Ϸ��ʼ
        FiveRoomState_GameOver,     //��Ϸ����

        FiveRoomState_End
    };

    //������ķ�λ
    enum PlayerSitSide_Enum
    {
        PlayerSitSide_Init = 0,
        PlayerSitSide_Left,
        PlayerSitSide_Right,
        PlayerSitSide_Middle,

        PlayerSitSide_End
    };

    //���ӵ�
    public enum ChessSign_Enum
    {
        ChessSign_Init = 0,
        ChessSign_White,
        ChessSign_Black,

        ChessSign_End
    };

    //��������
    public enum TexasPokerType_Enum
    {
        TexasPokerType_Init = 0,
        TexasPokerType_High,                //5�ŵ���
        TexasPokerType_Two,                 //��һ������������ŵ���
        TexasPokerType_TwoPairs,            //������������
        TexasPokerType_Three,               //����3�ŵ�����ͬ����+2�ŵ���
        TexasPokerType_Straight,            //��ɫ��ͬ��˳��
        TexasPokerType_SameColor,           //ͬ��
        TexasPokerType_Gourd,               //��«��3�ŵ�����ͬ����+2�ŵ�����ͬ����
        TexasPokerType_Four,                //������4�ŵ�����ͬ����+1�ŵ���
        TexasPokerType_Flush,               //��ͨͬ��˳
        TexasPokerType_RoyalFlush,          //�ʼ�ͬ��˳

        TexasPokerType
    };

    //���ݷ���״̬
    public enum TexasRoomState_Enum
    {
        TexasRoomState_Init = 0,

        TexasRoomState_WaitPlayerSit,       //�ȴ��������
        TexasRoomState_CountDownBegin,      //��Ϸ��ʼ����ʱ
        TexasRoomState_CutBlinds,           //�۵���Сäע
        TexasRoomState_GiveTwoPoke,         //��ÿ�����������
        TexasRoomState_AskFirstChip,        //��һ��ѯ��ÿ���� ��ע
        TexasRoomState_DealPublic_First,    //�����Ź������� 1
        TexasRoomState_AskSecondChip,       //�ڶ���ѯ��ÿ���� ��ע
        TexasRoomState_DealPublic_Second,   //��һ�Ź������� 2
        TexasRoomState_AskThirdChip,        //������ѯ��ÿ���� ��ע
        TexasRoomState_DealPublic_Third,    //��һ�Ź������� 3
        TexasRoomState_AskFourthChip,       //���Ĵ�ѯ��ÿ���� ��ע

        TexasRoomState_Resulet,             //��Ϸ���
        TexasRoomState_Over,                //�������ȴ�

        TexasRoomState_Max
    };

    //���ݷ���ȼ�
    public enum TexasRoomLevel_Enum
    {
        TexasRoomLevel_Init = 0,
        TexasRoomLevel_1,
        TexasRoomLevel_2,
        TexasRoomLevel_3,

        TexasRoomLevel_Max
    };

    //5��ţţ����״̬
    public enum AllKillRoomState_Enum
    {
        AllKillRoomState_Init = 0,

        AllKillRoomState_WaitBoss,
        AllKillRoomState_DealPokers,        //����
        AllKillRoomState_ChipIn,            //��ע
        AllKillRoomState_OpenPokers,        //����
        AllKillRoomState_GameWait,          //����ҿ�

        AllKillRoomState_Result,
        AllKillRoomState_End,

        AllKillRoomState
    };

    //5��ţţ�Ŷ����
    enum AllKillDeskSign_Enum
    {
        AllKillDeskSign_Boss = 0,
        AllKillDeskSign_1,
        AllKillDeskSign_2,
        AllKillDeskSign_3,
        AllKillDeskSign_4,

        AllKillDeskSign
    };

    enum AllKillSign_Enum
    {
        AllKillSign_Zero = 0,       //ûţ
        AllKillSign_One = 1,        //ţһ
        AllKillSign_Two = 2,        //ţ��
        AllKillSign_Three = 3,      //ţ��
        AllKillSign_Four = 4,       //ţ��
        AllKillSign_Five = 5,       //ţ��
        AllKillSign_Six = 6,        //ţ��
        AllKillSign_Seven = 7,      //ţ��
        AllKillSign_Eight = 8,      //ţ��
        AllKillSign_Nine = 9,       //ţ��
        AllKillSign_Ten = 10,   //ţţ
        AllKillSign_RedWin = 11,    //���ʤ
        AllKillSign_Tied = 12,  //ƽ��
        AllKillSign_BlueWin = 13,   //����ʤ
        AllKillSign_Double = 14,    //˫ţ
        AllKillSign_Max = 15,   //��С �廨 ��ը �Ļ�

        AllKillSign
    };

    enum AllKillMaxPokerType_Enum
    {
        AllKillMaxPokerType_None = 15,
        AllKillMaxPokerType_FourFlower, //�Ļ�
        AllKillMaxPokerType_FourBlust,  //��ը
        AllKillMaxPokerType_FiveFlower, //�廨
        AllKillMaxPokerType_FiveSmall,  //��С

        AllKillMaxPokerType
    };

    //���������ö��
    enum NewHand_Gift
    {
        NewHand_ThreeOne,       //����һ
        NewHand_6,              //��Ԫ
        NewHand_18,             //ʮ��Ԫ
        NewHand_30,             //��ʮԪ

        NewHand_Max
    };

    //�ػ������ö��
    enum Benefit_Gift
    {
        Benefit_68,             //68Ԫ���
        Benefit_128,
        Benefit_198,
        Benefit_328,
        Benefit_648,
        Benefit_1000,

        Benefit_Max
    };

    //�̵���Ʒ����
    enum newItemType
    {
        newItemType_None = 0,
        newItemType_Coin = 1,         //���
        newItemType_Diamond = 2,      //��ʯ
        newItemType_JingDong = 3,     //�������￨
        newItemType_Mobile = 4,       //�ֻ���ֵ��
        newItemType_NewHandGift = 5,  //�������
        newItemType_BenefitGift = 6,  //�ػ����
    };

    //�����ʲô״̬
    enum ActivityState_Enum
    {
        ActivityState_Init,
        ActivityState_Wait,         //�ȴ���ʼ
        ActivityState_In,           //���
        ActivityState_Over,         //�����

        ActivityState
    };

    //����͵�ö��
    enum ActivityType_Enum
    {
        ActivityType_Init,
        ActivityType_RedBag,            //�����

        ActivityType
    };

    enum BullHappyGameState_Enum
    {
        BullHappyGameState_Init,

        BullHappyRoomState_WaitOtherPlayer, //�ȴ����������
        BullHappyRoomState_Count,           //��ʼ�ȴ�����ʱ
        BullHappyRoomState_DealPokers,      //����
        BullHappyRoomState_DealBoss,        //��ׯ
        BullHappyRoomState_ChipIn,          //��ע
        BullHappyRoomState_Caculate,        //��ţ
        BullHappyRoomState_OpenPokers,      //����
        BullHappyRoomState_GameWait,        //����ҿ�

        BullHappyRoomState_Result,
        BullHappyRoomState_End,

        BullHappyGameState
    };
}