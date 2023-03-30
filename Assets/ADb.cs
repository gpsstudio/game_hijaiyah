using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds;
using GoogleMobileAds.Api;

public class ADb : MonoBehaviour
{
    private BannerView bannerView;
    private string bannerAdUnitId = "ca-app-pub-9214006915655070/9604309153";

    void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });

        // Request a banner ad.
        this.RequestBannerAd();
    }

    private void RequestBannerAd()
    {
        // Create a banner ad and load it.
        this.bannerView = new BannerView(bannerAdUnitId, AdSize.Banner, AdPosition.Bottom);
        AdRequest adRequest = new AdRequest.Builder().Build();

        this.bannerView.LoadAd(adRequest);
    }


    // Clean up the banner ad when the script is destroyed.
    private void OnDestroy()
    {
        if (this.bannerView != null)
        {
            this.bannerView.Destroy();
        }
    }
}
