using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoins : MonoBehaviour
{

    public AudioClip collectCoin;
    public Text coin;
    
    void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Coin")
        {
            Destroy (other.gameObject);
            PlayerPrefs.SetInt ("Coin", PlayerPrefs.GetInt ("Coin") + 2);
            coin.text = PlayerPrefs.GetInt ("Coin").ToString ();
            GetComponent <AudioSource> ().clip = collectCoin;
            GetComponent <AudioSource> ().Play ();
        }
    }
}
