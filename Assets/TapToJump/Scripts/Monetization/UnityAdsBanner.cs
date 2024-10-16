using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityAdsBanner : MonoBehaviour
{
    public string gameId = "4258223";
    public string placementId = "Banner_Android";
    public bool testMode = false;

  /*  void Start () {
        Advertisement.Initialize (gameId, testMode);
        StartCoroutine (ShowBannerWhenReady ());
    }

    IEnumerator ShowBannerWhenReady () {
        while (!Advertisement.IsReady (placementId)) {
            yield return new WaitForSeconds (0.5f);
        }
        Advertisement.Banner.SetPosition (BannerPosition.BOTTOM_CENTER);
        Advertisement.Banner.Show (placementId);
    }*/
}