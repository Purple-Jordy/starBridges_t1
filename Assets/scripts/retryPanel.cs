using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retryPanel : MonoBehaviour
{
    public GameObject star;
    public RewardedAds rewardedAds;

    // Start is called before the first frame update
    void Start()
    {
        rewardedAds._rewardedAdComplete.AddListener(Revive);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void retry()
    {

#if !UNITY_EDITOR
     Vibrate.vibrate((long)100);
#endif

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Revive()
    {

#if !UNITY_EDITOR
     Vibrate.vibrate((long)100);
#endif

        star.GetComponent<CircleMove>().PositionLoad();
        
    }

    public void OnClickReviveButton() {
        rewardedAds.ShowAd();
    }

}
