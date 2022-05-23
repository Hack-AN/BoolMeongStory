using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class QuestManager : MonoBehaviour
{
    public GameObject[] daily_quest_btns;
    public GameObject admanager;
    public GameObject message;

    private void Start()
    {
        DateTime dt_now = DateTime.Now;
        DateTime dt_start = Convert.ToDateTime(PlayerPrefs.GetString("stTime_quest"));

        TimeSpan hours = dt_now - dt_start;

        //테스트용
        //PlayerPrefs.SetInt("days_quest", 0);
        Debug.Log("days: " + hours.Days);
        Debug.Log("quest: " + PlayerPrefs.GetInt("days_quest"));
        Debug.Log(PlayerPrefs.GetString("stTime_quest"));
        if (hours.Days >= 2 && PlayerPrefs.GetInt("days_quest") <= 19)
        {

            PlayerPrefs.SetInt("days_quest", 0);
            daily_quest_btns[0].GetComponent<Button>().interactable = true;
            daily_quest_btns[0].transform.GetChild(2).gameObject.SetActive(false);
            PlayerPrefs.SetString("stTime_quest", DateTime.Now.ToString());
            for (int i = 1; i < daily_quest_btns.Length; i++)
            {
                daily_quest_btns[i].GetComponent<Button>().interactable = false;
                daily_quest_btns[i].transform.GetChild(2).gameObject.SetActive(false);
            }
        }
        else if(PlayerPrefs.GetInt("days_quest") <= 19)
        {
            for (int i = 0; i < PlayerPrefs.GetInt("days_quest"); i++)
            {
                daily_quest_btns[i].GetComponent<Button>().interactable = false;
                daily_quest_btns[i].transform.GetChild(2).gameObject.SetActive(true);
            }

            for (int i = PlayerPrefs.GetInt("days_quest") + 1; i < daily_quest_btns.Length; i++)
            {
                daily_quest_btns[i].GetComponent<Button>().interactable = false;
                daily_quest_btns[i].transform.GetChild(2).gameObject.SetActive(false);
            }

            if (hours.Days == 1 && daily_quest_btns[PlayerPrefs.GetInt("days_quest")].GetComponent<Button>().interactable == false)
            {
                daily_quest_btns[PlayerPrefs.GetInt("days_quest")].GetComponent<Button>().interactable = true;
                daily_quest_btns[PlayerPrefs.GetInt("days_quest")].transform.GetChild(2).gameObject.SetActive(false);
            }
        }


    }

    public void daily_quest(int index)
    {
        if(daily_quest_btns[index].GetComponent<Button>().interactable == true)
        {
            daily_quest_btns[index].GetComponent<Button>().interactable = false;
            daily_quest_btns[index].transform.GetChild(2).gameObject.SetActive(true);
            PlayerPrefs.SetInt("days_quest", PlayerPrefs.GetInt("days_quest") + 1);
            PlayerPrefs.SetString("stTime_quest", DateTime.Now.ToString());
            switch (index)
            {
                case 0:
                    GameManager.Instance.increase_haert(1000);
                    break;
                case 1:
                    GameManager.Instance.increase_haert(3000);
                    break;
                case 2:
                    GameManager.Instance.increase_haert(6000);
                    break;
                case 3:
                    GameManager.Instance.increase_haert(10000);
                    break;
                case 4:
                    GameManager.Instance.increase_haert(13000);
                    break;
                case 5:
                    GameManager.Instance.increase_haert(16000);
                    break;
                case 6:
                    GameManager.Instance.increase_haert(20000);
                    break;
                case 7:
                    GameManager.Instance.increase_haert(24000);
                    break;
                case 8:
                    GameManager.Instance.increase_haert(27000);
                    break;
                case 9:
                    Debug.Log("광고제거버튼성공");
                    PlayerPrefs.SetInt("is_removed_banner_ad", 1);
                    // 바로 배너 광고 내리기
                    admanager.GetComponent<AdManager>().remove_banner();
                    break;
                case 10:
                    GameManager.Instance.increase_haert(30000);
                    break;
                case 11:
                    GameManager.Instance.increase_haert(32000);
                    break;
                case 12:
                    GameManager.Instance.increase_haert(36000);
                    break;
                case 13:
                    GameManager.Instance.increase_haert(40000);
                    break;
                case 14:
                    GameManager.Instance.increase_haert(45000);
                    break;
                case 15:
                    GameManager.Instance.increase_haert(50000);
                    break;
                case 16:
                    GameManager.Instance.increase_haert(53000);
                    break;
                case 17:
                    GameManager.Instance.increase_haert(57000);
                    break;
                case 18:
                    GameManager.Instance.increase_haert(60000);
                    break;
                case 19:
                    PlayerPrefs.SetInt("is_removed_screeen_ad", 1);
                    break;
            }
        }

    }


    public void daily_present()
    {
        DateTime dt_now = DateTime.Now;
        DateTime dt_start = Convert.ToDateTime(PlayerPrefs.GetString("stTime_present"));

        TimeSpan hours = dt_now - dt_start;

        if(hours.Days == 0)
        {
            // 내일부터 받아보세요!
            StartCoroutine("appear");
        }
        else
        {
            // 광고 보고 보상 주고, 오늘로 시작 일시 저장
            admanager.GetComponent<AdManager>().UserChoseToWatchAd();
            PlayerPrefs.SetString("stTime_present", DateTime.Now.ToString());
        }
    }

    IEnumerator appear()
    {
        message.SetActive(true);

        yield return new WaitForSeconds(2f);

        message.SetActive(false);
    }
}
