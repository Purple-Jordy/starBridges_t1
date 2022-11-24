using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Continue : MonoBehaviour
{
    // Start is called before the first frame update
   
    void Start()
    {

    }

    public void LoadGame()
    {

#if !UNITY_EDITOR
     Vibrate.vibrate((long)100);
#endif

        SceneManager.LoadScene(PlayerPrefs.GetInt("SavedScene"));
    }

}
