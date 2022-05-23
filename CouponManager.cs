using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Toast.Gamebase;
using UnityEngine.UI;
using UnityEngine.Networking;

public class CouponManager : MonoBehaviour
{
    public InputField field;
    public Button btn;
    public Text message;

    public void empty()
    {
        message.text = "";
    }

    public void check()
    {
        if(PlayerPrefs.GetInt("usedcoupon") == 0)
        {
            if (field.text == "3fd29k94kdcg583ju83dyd")
            {
                PlayerPrefs.SetInt("heart_num", PlayerPrefs.GetInt("heart_num") + 400000);
                message.text = "선물이 지급되었습니다.";
                PlayerPrefs.SetInt("usedcoupon", 1);
            }
            else
            {
                message.text = "쿠폰 번호가 일치하지 않습니다.";
            }
        }
        else
        {
            message.text = "이미 사용한 쿠폰입니다.";
        }


    }


    // Start is called before the first frame update

        /*
    void Start()
    {
        Initialize();
    }
    public void Initialize()
    {
        
         //Show gamebase debug message.
         //set 'false' when build RELEASE.
         
        Gamebase.SetDebugMode(true);

//Gamebase Configuration.

        var configuration = new GamebaseRequest.GamebaseConfiguration();
        configuration.appID = "	Dp52IOCb";
        configuration.appVersion = "6";
        configuration.displayLanguageCode = GamebaseDisplayLanguageCode.English;
#if UNITY_ANDROID
        configuration.storeCode = GamebaseStoreCode.GOOGLE;
#elif UNITY_IOS
        configuration.storeCode = GamebaseStoreCode.APPSTORE;
#elif UNITY_WEBGL
        configuration.storeCode = GamebaseStoreCode.WEBGL;
#elif UNITY_STANDALONE
        configuration.storeCode = GamebaseStoreCode.WINDOWS;
#else
        configuration.storeCode = GamebaseStoreCode.WINDOWS;
#endif

        
        // Gamebase Initialize.
         
        Gamebase.Initialize(configuration, (launchingInfo, error) =>
        {
            if (Gamebase.IsSuccess(error) == true)
            {
                Debug.Log("Initialization succeeded.");

                //Following notices are registered in the Gamebase Console
                var notice = launchingInfo.launching.notice;
                if (notice != null)
                {
                    if (string.IsNullOrEmpty(notice.message) == false)
                    {
                        Debug.Log(string.Format("title:{0}", notice.title));
                        Debug.Log(string.Format("message:{0}", notice.message));
                        Debug.Log(string.Format("url:{0}", notice.url));
                    }
                }

                //Status information of game app version set in the Gamebase Unity SDK initialization.
                var status = launchingInfo.launching.status;

                // Game status code (e.g. Under maintenance, Update is required, Service has been terminated)
                // refer to GamebaseLaunchingStatus
                if (status.code == GamebaseLaunchingStatus.IN_SERVICE)
                {
                    // Service is now normally provided.
                    Login();
                }
                else
                {
                    switch (status.code)
                    {
                        case GamebaseLaunchingStatus.RECOMMEND_UPDATE:
                            {
                                // Update is recommended.
                                break;
                            }
                        // ... 
                        case GamebaseLaunchingStatus.INTERNAL_SERVER_ERROR:
                            {
                                // Error in internal server.
                                break;
                            }
                    }
                }
            }
            else
            {
                // Check the error code and handle the error appropriately.
                Debug.Log(string.Format("Initialization failed. error is {0}", error));

                if (error.code == GamebaseErrorCode.LAUNCHING_UNREGISTERED_CLIENT)
                {
                    GamebaseResponse.Launching.UpdateInfo updateInfo = GamebaseResponse.Launching.UpdateInfo.From(error);
                    if (updateInfo != null)
                    {
                        // Update is require.
                    }
                }
            }
        });
    }




    public void check_code()
    {


        StartCoroutine("Upload");





    }
    IEnumerator Upload()
    {
        //List<IMultipartFormSection> formData = new List<IMultipartFormSection>();
        //formData.Add(new MultipartFormDataSection("appId", "qTxhJN6n"));
        //formData.Add(new MultipartFormDataSection("userId", GameManager.Instance.userid));
        //formData.Add(new MultipartFormDataSection("couponCode", field.text));
        //formData.Add(new MultipartFormDataSection("storeCode", "ALL"));

        WWWForm form = new WWWForm();
        form.AddField("appId", "Dp52IOCb");
        form.AddField("userId", GameManager.Instance.userid);
        form.AddField("couponCode", field.text);


        UnityWebRequest www = UnityWebRequest.Post("https://api-gamebase.cloud.toast.com/tcgb-gateway/v1.3/apps/{appId}/members/{userId}/coupons/{couponCode}?storeCode={storeCode}", form);

        DownloadHandlerBuffer dH = new DownloadHandlerBuffer();
        www.downloadHandler = dH;

        yield return www.SendWebRequest();


        Debug.Log(www.downloadHandler.text);

        if (www.isNetworkError || www.isHttpError)
        {
            //Debug.Log(www.text); 
            Debug.Log(www.error);
            message.text = "쿠폰 실패...";
        }
        else
        {
            Debug.Log("Form upload complete!");
            message.text = "쿠폰 사용 성공!";
            PlayerPrefs.SetInt("infinity_craft", 1);


        }

        Logout();
    }
    private const string MESSAGE_NOT_IMPLEMENTED = "Not implemented.";



    public static void Login()
    {
        Gamebase.Login(GamebaseAuthProvider.GUEST, (authToken, error) =>
        {
            if (Gamebase.IsSuccess(error) == true)
            {
                //SampleLogger.Log(string.Format("Guest login succeeded. User ID:{0}", authToken.member.userId));
                Debug.Log("게스트 로그인 성공: " + authToken.member.userId);
                GameManager.Instance.userid = authToken.member.userId;
            }
            else
            {
                Debug.Log("게스트 로그인 실패: "+ error);
                //SampleLogger.Log(string.Format("Guest login failed. Error:{0}", error));
            }
        });
        
    }

    public static void Logout()
    {
        Gamebase.Logout((error) =>
        {
            if (Gamebase.IsSuccess(error) == true)
            {
                Debug.Log("로그아웃 성공.");
                //SampleLogger.Log("Logout succeeded.");
            }
            else
            {
                Debug.Log("로그아웃 실패: " + error);
            }
        });
    }
    */
}