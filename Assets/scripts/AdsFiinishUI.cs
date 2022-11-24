using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdsFiinishUI : MonoBehaviour
{

    [SerializeField] InterstitialAds interstitialAds;

    void Awake()
    {
        interstitialAds = Object.FindObjectOfType<InterstitialAds>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Invoke("AwakeAds", 5);
    }

    // Update is called once per frame
    

    void AwakeAds()
    {
        if (interstitialAds)
        {
            string playedRoundsNumKey = "PlayedRoundsNum";
            int roundCnt = PlayerPrefs.GetInt(playedRoundsNumKey);
            roundCnt++;
            PlayerPrefs.SetInt(playedRoundsNumKey, roundCnt);
            if (roundCnt > 2)
            {
                interstitialAds.ShowAd();
            }
        }
    }

}
