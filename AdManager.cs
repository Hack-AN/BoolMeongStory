using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;
using GoogleMobileAds.Common;

public class AdManager : MonoBehaviour
{
    private BannerView bannerView;
    private InterstitialAd interstitial;
    private RewardedAd rewardedAd;

    public GameObject pagemanager;
    int page_index;
    public GameObject daily_present_window;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("¹è³Ê±¤°í: " + PlayerPrefs.GetInt("is_removed_banner_ad"));
        Debug.Log("Àü¸é±¤°í: " + PlayerPrefs.GetInt("is_removed_screen_ad"));

        // Initialize the Google Mobile Ads SDK.
        if (PlayerPrefs.GetInt("is_removed_banner_ad") == 0)
            MobileAds.Initialize(HandleInitCompleteAction);

        /*
        if (PlayerPrefs.GetInt("is_removed_banner_ad") == 0)
        {
            // Clean up banner before reusing
            while (bannerView != null)
            {
                
                bannerView.Destroy();
            }

            this.RequestBanner();
        }

        */
        if (PlayerPrefs.GetInt("is_removed_screen_ad") == 0)
        {
            if (interstitial != null)
                interstitial.Destroy();


            this.RequestInterstitial();
        }
            

        //CreateAndLoadRewardedAd();
    }

    private void HandleInitCompleteAction(InitializationStatus initstatus)
    {
        // Callbacks from GoogleMobileAds are not guaranteed to be called on
        // main thread.
        // In this example we use MobileAdsEventExecutor to schedule these calls on
        // the next Update() loop.
        MobileAdsEventExecutor.ExecuteInUpdate(() =>
        {
            this.RequestBanner();
        });
    }

    private void RequestBanner()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-1284980277767839/7653279681";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/2934735716";
#else
            string adUnitId = "unexpected_platform";
#endif

        Debug.Log("ddd");

        // Create a 320x50 banner at the top of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Top);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);
    }

    // ¹è³Ê ±¤°í Á¦°Å
    
    public void remove_banner()
    {
        bannerView.Destroy();
    }
    

    private void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-1284980277767839/1469007109";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/4411468910";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Initialize an InterstitialAd.
        this.interstitial = new InterstitialAd(adUnitId);


                // Called when the ad is closed.
        this.interstitial.OnAdClosed += HandleOnAdClosed;
        
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        this.interstitial.LoadAd(request);


    }

    public void call_interstitial(int index)
    {
        page_index = index;
        Debug.Log(PlayerPrefs.GetInt("is_removed_screen_ad"));
        if(PlayerPrefs.GetInt("is_removed_screen_ad") == 0 && PlayerPrefs.GetInt("num_screen_ad") == 0)
        {
            if (this.interstitial.IsLoaded())
            {
                PlayerPrefs.SetInt("num_screen_ad", 1);
                this.interstitial.Show();
            }
            else
            {
                Debug.Log("Àü¸é ±¤°í ¿À·ù");
                pagemanager.GetComponent<PageManager>().open_stage(page_index);
            }
        }
        else
        {
            pagemanager.GetComponent<PageManager>().open_stage(page_index);
            PlayerPrefs.SetInt("num_screen_ad", 0);
        }

    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdClosed event received");
        pagemanager.GetComponent<PageManager>().open_stage(page_index);
        this.RequestInterstitial();

    }
    public void CreateAndLoadRewardedAd()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-9064482124468196/3665644235";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
            string adUnitId = "unexpected_platform";
#endif



        this.rewardedAd = new RewardedAd(adUnitId);

        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        this.rewardedAd.LoadAd(request);
    }
    public void UserChoseToWatchAd()
    {
        if (this.rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();
        }
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
        string type = args.Type;
        double amount = args.Amount;
        MonoBehaviour.print(
             "HandleRewardedAdRewarded event received for "
                 + amount.ToString() + " " + type);
        
        daily_present_window.SetActive(true);
        PlayerPrefs.SetInt("heart_num", PlayerPrefs.GetInt("heart_num") + 300);
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        this.CreateAndLoadRewardedAd();
    }
}
