using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public GameObject[] purchase_btns;
    public GameObject servermanager;
    public GameObject admanager;

    private void Start()
    {
        if (PlayerPrefs.GetInt("is_removed_banner_ad") == 0 && PlayerPrefs.GetInt("is_removed_screen_ad") == 0)
        {
            purchase_btns[0].GetComponent<Button>().interactable = true;
            purchase_btns[0].transform.GetChild(0).GetComponent<Text>().text = "광고 제거 / 3,000원";
        }
        else
        {
            purchase_btns[0].GetComponent<Button>().interactable = false;
            purchase_btns[0].transform.GetChild(0).GetComponent<Text>().text = "광고 제거 / 구입완료";
        }
       
    }

    public void purchase(int index)
    {
        switch(index)
        {
            // remove ad
            case 1:
                purchase_btns[0].GetComponent<Button>().interactable = false;
                purchase_btns[0].transform.GetChild(0).GetComponent<Text>().text = "광고 제거 / 구입완료";
                PlayerPrefs.SetInt("is_removed_banner_ad", 1);
                PlayerPrefs.SetInt("is_removed_screen_ad", 1);
                admanager.GetComponent<AdManager>().remove_banner();
                break;
            // heart1
            case 2:
                PlayerPrefs.SetInt("heart_num", PlayerPrefs.GetInt("heart_num") + 1000);
                break;
            // heart2.5
            case 3:
                PlayerPrefs.SetInt("heart_num", PlayerPrefs.GetInt("heart_num") + 2500);
                break;
            // heart7
            case 4:
                PlayerPrefs.SetInt("heart_num", PlayerPrefs.GetInt("heart_num") + 7000);
                break;
            // heart10
            case 5:
                PlayerPrefs.SetInt("heart_num", PlayerPrefs.GetInt("heart_num") + 10000);
                break;
            // 후원 기능은 ServerManager.cs에서 구현
        }
    }
}
