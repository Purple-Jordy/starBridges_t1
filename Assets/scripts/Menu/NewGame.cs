using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void NewGame()
    {

#if !UNITY_EDITOR
     Vibrate.vibrate((long)100);
#endif


        SceneManager.LoadScene("AriesScene");
    }

    public void LoadGame()
    {

#if !UNITY_EDITOR
     Vibrate.vibrate((long)100);
#endif


        SceneManager.LoadScene(PlayerPrefs.GetInt("SavedScene"));
    }


}
