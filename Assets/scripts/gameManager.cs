using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject PauseUI; 

    public static gameManager I;

    void Awake()
    {
        
    }



    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
     
        if(Application.platform == RuntimePlatform.Android)
        {

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                //back button
                Time.timeScale = 0;
                PauseUI.SetActive(true);
                
                
            }


            if (Input.GetKeyDown(KeyCode.Home))
            {
                //home button
                Time.timeScale = 0;
                PauseUI.SetActive(true);
            }


            if (Input.GetKeyDown(KeyCode.Menu))
            {
                //menu button
                Time.timeScale = 0;
                PauseUI.SetActive(true);
            }


        }
        



    }




}
