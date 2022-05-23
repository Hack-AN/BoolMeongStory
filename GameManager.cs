using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;
    float time = 0;
    public Text heart_text;
    public Image title;
    public GameObject panel;
    public string userid;

    public GameObject pagemanager;
    public bool touched = false;

    void Awake()
    {
        StartCoroutine("intro");

        if (null == instance)
        {
            //이 클래스 인스턴스가 탄생했을 때 전역변수 instance에 게임매니저 인스턴스가 담겨있지 않다면, 자신을 넣어준다.
            instance = this;

            if (PlayerPrefs.HasKey("usedcoupon") == false)
                PlayerPrefs.SetInt("usedcoupon", 0);

            if (PlayerPrefs.HasKey("num_screen_ad") == false)
                PlayerPrefs.SetInt("num_screen_ad", 0);
            //PlayerPrefs.SetInt("is_removed_banner_ad", 0);
            //PlayerPrefs.SetInt("is_removed_screen_ad", 0);
            if (PlayerPrefs.HasKey("is_removed_banner_ad") == false)
                PlayerPrefs.SetInt("is_removed_banner_ad", 0);

            if (PlayerPrefs.HasKey("is_removed_screen_ad") == false)
                PlayerPrefs.SetInt("is_removed_screen_ad", 0);

            if (PlayerPrefs.HasKey("heart_num") == false)
                PlayerPrefs.SetInt("heart_num", 0);
            /*
            else
                PlayerPrefs.SetInt("heart_num", 700);
                */
            if (PlayerPrefs.HasKey("stTime_quest") == false)
                PlayerPrefs.SetString("stTime_quest", DateTime.Now.ToString());

            if (PlayerPrefs.HasKey("days_quest") == false)
                PlayerPrefs.SetInt("days_quest", 0);

            if (PlayerPrefs.HasKey("stTime_present") == false)
                PlayerPrefs.SetString("stTime_present", DateTime.Now.ToString());

            if (PlayerPrefs.HasKey("fire_1") == false)
                PlayerPrefs.SetInt("fire_1", 0);
            if (PlayerPrefs.HasKey("fire_2") == false)
                PlayerPrefs.SetInt("fire_2", 0);
            if (PlayerPrefs.HasKey("fire_3") == false)
                PlayerPrefs.SetInt("fire_3", 0);
            if (PlayerPrefs.HasKey("fire_4") == false)
                PlayerPrefs.SetInt("fire_5", 0);
            if (PlayerPrefs.HasKey("fire_5") == false)
                PlayerPrefs.SetInt("fire_5", 0);
            if (PlayerPrefs.HasKey("fire_6") == false)
                PlayerPrefs.SetInt("fire_6", 0);
            if (PlayerPrefs.HasKey("fire_7") == false)
                PlayerPrefs.SetInt("fire_7", 0);
            if (PlayerPrefs.HasKey("fire_8") == false)
                PlayerPrefs.SetInt("fire_8", 0);
            if (PlayerPrefs.HasKey("fire_9") == false)
                PlayerPrefs.SetInt("fire_9", 0);
            if (PlayerPrefs.HasKey("fire_10") == false)
                PlayerPrefs.SetInt("fire_10", 0);

            if (PlayerPrefs.HasKey("night_1") == false)
                PlayerPrefs.SetInt("night_1", 0);
            if (PlayerPrefs.HasKey("night_2") == false)
                PlayerPrefs.SetInt("night_2", 0);
            if (PlayerPrefs.HasKey("night_3") == false)
                PlayerPrefs.SetInt("night_3", 0);
            if (PlayerPrefs.HasKey("night_4") == false)
                PlayerPrefs.SetInt("night_5", 0);
            if (PlayerPrefs.HasKey("night_5") == false)
                PlayerPrefs.SetInt("night_5", 0);
            if (PlayerPrefs.HasKey("night_6") == false)
                PlayerPrefs.SetInt("night_6", 0);
            if (PlayerPrefs.HasKey("night_7") == false)
                PlayerPrefs.SetInt("night_7", 0);
            if (PlayerPrefs.HasKey("night_8") == false)
                PlayerPrefs.SetInt("night_8", 0);
            if (PlayerPrefs.HasKey("night_9") == false)
                PlayerPrefs.SetInt("night_9", 0);
            if (PlayerPrefs.HasKey("night_10") == false)
                PlayerPrefs.SetInt("night_10", 0);

            if (PlayerPrefs.HasKey("forest_1") == false)
                PlayerPrefs.SetInt("forest_1", 0);
            if (PlayerPrefs.HasKey("forest_2") == false)
                PlayerPrefs.SetInt("forest_2", 0);
            if (PlayerPrefs.HasKey("forest_3") == false)
                PlayerPrefs.SetInt("forest_3", 0);
            if (PlayerPrefs.HasKey("forest_4") == false)
                PlayerPrefs.SetInt("forest_5", 0);
            if (PlayerPrefs.HasKey("forest_5") == false)
                PlayerPrefs.SetInt("forest_5", 0);
            if (PlayerPrefs.HasKey("forest_6") == false)
                PlayerPrefs.SetInt("forest_6", 0);
            if (PlayerPrefs.HasKey("forest_7") == false)
                PlayerPrefs.SetInt("forest_7", 0);
            if (PlayerPrefs.HasKey("forest_8") == false)
                PlayerPrefs.SetInt("forest_8", 0);
            if (PlayerPrefs.HasKey("forest_9") == false)
                PlayerPrefs.SetInt("forest_9", 0);
            if (PlayerPrefs.HasKey("forest_10") == false)
                PlayerPrefs.SetInt("forest_10", 0);

            if (PlayerPrefs.HasKey("rain_1") == false)
                PlayerPrefs.SetInt("rain_1", 0);
            if (PlayerPrefs.HasKey("rain_2") == false)
                PlayerPrefs.SetInt("rain_2", 0);
            if (PlayerPrefs.HasKey("rain_3") == false)
                PlayerPrefs.SetInt("rain_3", 0);
            if (PlayerPrefs.HasKey("rain_4") == false)
                PlayerPrefs.SetInt("rain_5", 0);
            if (PlayerPrefs.HasKey("rain_5") == false)
                PlayerPrefs.SetInt("rain_5", 0);
            if (PlayerPrefs.HasKey("rain_6") == false)
                PlayerPrefs.SetInt("rain_6", 0);
            if (PlayerPrefs.HasKey("rain_7") == false)
                PlayerPrefs.SetInt("rain_7", 0);
            if (PlayerPrefs.HasKey("rain_8") == false)
                PlayerPrefs.SetInt("rain_8", 0);
            if (PlayerPrefs.HasKey("rain_9") == false)
                PlayerPrefs.SetInt("rain_9", 0);
            if (PlayerPrefs.HasKey("rain_10") == false)
                PlayerPrefs.SetInt("rain_10", 0);
            //씬 전환이 되더라도 파괴되지 않게 한다.
            //gameObject만으로도 이 스크립트가 컴포넌트로서 붙어있는 Hierarchy상의 게임오브젝트라는 뜻이지만, 
            //나는 헷갈림 방지를 위해 this를 붙여주기도 한다.
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            //만약 씬 이동이 되었는데 그 씬에도 Hierarchy에 GameMgr이 존재할 수도 있다.
            //그럴 경우엔 이전 씬에서 사용하던 인스턴스를 계속 사용해주는 경우가 많은 것 같다.
            //그래서 이미 전역변수인 instance에 인스턴스가 존재한다면 자신(새로운 씬의 GameMgr)을 삭제해준다.
            Destroy(this.gameObject);
        }
    }

    //게임 매니저 인스턴스에 접근할 수 있는 프로퍼티. static이므로 다른 클래스에서 맘껏 호출할 수 있다.
    public static GameManager Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }

    private void Update()
    {
        time += Time.deltaTime;

        if(touched == true)
        {
            if (time >= 3f)
            {
                touched = false;
                time = 0;
            }
            else
                return;
        }

        if (time >= 1f)
        {
            time = 0;
            PlayerPrefs.SetInt("heart_num", PlayerPrefs.GetInt("heart_num") + 1);
            heart_text.text = PlayerPrefs.GetInt("heart_num").ToString();
        }

        if(Application.platform == RuntimePlatform.Android)
        {
            if(Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }

    public void increase_haert(int value)
    {
        PlayerPrefs.SetInt("heart_num", PlayerPrefs.GetInt("heart_num") + value);
    }

    public void decrease_haert(int value)
    {
        PlayerPrefs.SetInt("heart_num", PlayerPrefs.GetInt("heart_num") - value);
    }

    public void open_url(string url)
    {
        Application.OpenURL(url);
    }

    public IEnumerator intro()
    {
        while(title.color.a < 1)
        {
            title.color = new Color(title.color.r, title.color.g, title.color.b, title.color.a + Time.deltaTime);
            yield return null;
        }

        yield return new WaitForSeconds(2f);

        panel.SetActive(false);
    }
}
