using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipTuto : MonoBehaviour
{
    public void GoAriesSence()
    {
        SceneManager.LoadScene("AriesScene");
        Time.timeScale = 1;

#if !UNITY_EDITOR
     Vibrate.vibrate((long)100);
#endif

        PlayerPrefs.SetInt("SavedScene", 11);
        PlayerPrefs.Save();

    }

}
