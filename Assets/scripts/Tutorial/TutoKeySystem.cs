using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TutoKeySystem : MonoBehaviour
{
    
    public GameObject starLine;
    public int count;
    public int touchCount;
    public GameObject star;
    public GameObject fullShot;
    public GameObject cam;
    public GameObject camBound;
    public GameObject successNameUI;
    public GameObject image;
    public GameObject finishUi;
    public GameObject countUi;
    public GameObject firstPlanet;
    public GameObject starTarget;

    public float full;
    public float zoomSpeed;
    public Text CountText;
    public Text TouchCountText;



    // Update is called once per frame
    void Update()
    {
        if (count == touchCount)
        {
                        
            cam.GetComponent<camera>().target = fullShot;
                      
            Invoke("finishUI", 1);


        }

        CountText.text = count.ToString();
        TouchCountText.text = touchCount.ToString();

    }

    void LateUpdate()
    {
        if (count == touchCount)
        {
            
            //zoom();
            countUi.SetActive(false);




            


        }
        
    }



    void wait()
    {
        starLine.SetActive(true);
        //starLine.GetComponent<AnimLine>().enabled = true;
    }

    void zoom()
    {
        cam.GetComponent<camera>().speed = 1.5f; //카메라 타겟으로 이동 속도 
        cam.GetComponent<camera>().zoomSpeed = zoomSpeed; //카메라 확대 속도 
        cam.GetComponent<camera>().camwidth = full; // 카메라 확대 넓이
        //cam.GetComponent<camera>().zoom();
        //cam.GetComponent<Camera>().fieldOfView = viewSize;
        camBound.SetActive(false);
        
    }



    void Name()
    {
        successNameUI.SetActive(true);
    }

    void starImage()
    {
        image.SetActive(true);
    }

    void finishUI()
    {
        finishUi.SetActive(true);
    }

    void Vibe()
    {
#if !UNITY_EDITOR
     Vibrate.vibrate((long)100);
#endif

    }


}
