using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class UnityAdsRewarded : MonoBehaviour
{
    public Text coin, coinShop;
    public Text rewardText;
    //private int rewardCount = 0;

    public void ShowRewardedVideo()
    {
       /* if (Advertisement.IsReady("Rewarded_Android"))
        {
            Advertisement.Show("Rewarded_Android");
            //rewardCount++;
            PlayerPrefs.SetInt ("Coin", PlayerPrefs.GetInt ("Coin") + 5);
            coin.text = PlayerPrefs.GetInt ("Coin").ToString ();
            coinShop.text = PlayerPrefs.GetInt ("Coin").ToString ();
            //rewardText.text = " " + rewardCount.ToString();
        }
        else
        {
            PlayerPrefs.SetInt ("Coin", PlayerPrefs.GetInt ("Coin") + 0);
            //не показало
        }
        */
    }
}
