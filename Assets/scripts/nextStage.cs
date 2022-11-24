using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextStage : MonoBehaviour
{
    [SerializeField] InterstitialAds interstitialAds;
    
    // Start is called before the first frame update
    void Start()
    {
        interstitialAds = Object.FindObjectOfType<InterstitialAds>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadNextScene()
    {
        

        //ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ ï¿½Â´ï¿½
        Scene scene = SceneManager.GetActiveScene();

        //ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ ï¿½Â´ï¿½
        int curScene = scene.buildIndex;

        //ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ ï¿½Ù·ï¿½ ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ +1ï¿½ï¿½ ï¿½ï¿½ï¿½Ø´ï¿½.
        int nextScene = curScene + 1;

        //ï¿½ï¿½ï¿½ï¿½ ï¿½ï¿½ï¿½ï¿½ ï¿½Ò·ï¿½ï¿½Â´ï¿½
        SceneManager.LoadScene(nextScene);

#if !UNITY_EDITOR
     Vibrate.vibrate((long)100);
#endif


        // ´ÙÀ½ ¾ÀÀ» ÀúÀåÇÑ´Ù 
        PlayerPrefs.SetInt("SavedScene", SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.Save();

    }

    void ads()
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
