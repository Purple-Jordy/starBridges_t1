using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class PauseButton : MonoBehaviour
{

    public GameObject PauseUI;

    public AudioSource CamBgm;
    

    

    public void Pause()
    {

#if !UNITY_EDITOR
     Vibrate.vibrate((long)100);
#endif
        Time.timeScale = 0;
        PauseUI.SetActive(true);
        CamBgm.Pause();




    }



}
