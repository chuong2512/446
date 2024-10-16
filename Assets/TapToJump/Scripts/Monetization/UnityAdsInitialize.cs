using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAdsInitialize : MonoBehaviour
{
#if UNITY_IOS
    private string gameId = "4258222";
#elif UNITY_ANDROID
    private string gameId = "4258223";
#endif

    void Start()
    {
       // Advertisement.Initialize(gameId, false);
    }
}
