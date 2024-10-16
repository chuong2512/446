using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountCurrency : MonoBehaviour
{
    private Text txt;

    void Start()
    {
        txt = GetComponent<Text>();
    }


    private void Update()
    {
        txt.text = PlayerPrefs.GetInt("Coin").ToString();
    }
}