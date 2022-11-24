using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class keySystem : MonoBehaviour
{
    
    public GameObject starLine;
    public int count;
    public int touchCount;
    public GameObject star;
    public GameObject fullShot;
    public GameObject cam;
    public GameObject camBound;
    public GameObject success;
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

            //star.SetActive(false);
            //star.GetComponent<CircleMove>().panel.SetActive(false);
            wait();
            //Invoke("wait", 1);
            cam.GetComponent<camera>().target = fullShot;
            Invoke("Name", 2);
            Invoke("starImage", 3);           
            Invoke("finishUI", 8);


            //campoint.target = fullShot;

        }

        CountText.text = count.ToString();
        TouchCountText.text = touchCount.ToString();

    }

    void LateUpdate()
    {
        if (count == touchCount)
        {
            star.SetActive(false);
            starTarget.GetComponent<CircleTarget>().panel.SetActive(false);
            zoom();
            countUi.SetActive(false);




            GameObject yellow = firstPlanet.transform.GetChild(1).gameObject;
            yellow.SetActive(false);
            GameObject white = firstPlanet.transform.GetChild(2).gameObject;
            white.SetActive(true);


        }
        
    }



    void wait()
    {
        starLine.SetActive(true);
        //starLine.GetComponent<AnimLine>().enabled = true;
    }

    void zoom()
    {
        cam.GetComponent<camera>().speed = 1.5f; //ī�޶� Ÿ������ �̵� �ӵ� 
        cam.GetComponent<camera>().zoomSpeed = zoomSpeed; //ī�޶� Ȯ�� �ӵ� 
        cam.GetComponent<camera>().camwidth = full; // ī�޶� Ȯ�� ����
        //cam.GetComponent<camera>().zoom();
        //cam.GetComponent<Camera>().fieldOfView = viewSize;
        camBound.SetActive(false);
        
    }



    void Name()
    {
        success.SetActive(true);
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
