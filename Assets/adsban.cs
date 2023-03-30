using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.SceneManagement;

public class adsban : MonoBehaviour
{
    private BannerView bannerView;
    public void Start()
    {
        MobileAds.Initialize(initStatus => { });
        RequestConfiguration requestConfiguration = new RequestConfiguration.Builder()
         .SetTagForChildDirectedTreatment(TagForChildDirectedTreatment.True)
         .build();
        MobileAds.SetRequestConfiguration(requestConfiguration);
        this.RequestBanner();
    }

    private void RequestBanner()
    {

        string adUnitId = "ca-app-pub-9214006915655070/9604309153";


        // Create a 320x50 banner at the bottom of the screen.
        this.bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        this.bannerView.LoadAd(request);
    }
}
