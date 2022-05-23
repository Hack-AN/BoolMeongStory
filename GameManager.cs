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
            //�� Ŭ���� �ν��Ͻ��� ź������ �� �������� instance�� ���ӸŴ��� �ν��Ͻ��� ������� �ʴٸ�, �ڽ��� �־��ش�.
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
            //�� ��ȯ�� �Ǵ��� �ı����� �ʰ� �Ѵ�.
            //gameObject�����ε� �� ��ũ��Ʈ�� ������Ʈ�μ� �پ��ִ� Hierarchy���� ���ӿ�����Ʈ��� ��������, 
            //���� �򰥸� ������ ���� this�� �ٿ��ֱ⵵ �Ѵ�.
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            //���� �� �̵��� �Ǿ��µ� �� ������ Hierarchy�� GameMgr�� ������ ���� �ִ�.
            //�׷� ��쿣 ���� ������ ����ϴ� �ν��Ͻ��� ��� ������ִ� ��찡 ���� �� ����.
            //�׷��� �̹� ���������� instance�� �ν��Ͻ��� �����Ѵٸ� �ڽ�(���ο� ���� GameMgr)�� �������ش�.
            Destroy(this.gameObject);
        }
    }

    //���� �Ŵ��� �ν��Ͻ��� ������ �� �ִ� ������Ƽ. static�̹Ƿ� �ٸ� Ŭ�������� ���� ȣ���� �� �ִ�.
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
