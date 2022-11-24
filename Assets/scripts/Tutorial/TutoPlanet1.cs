using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TutoPlanet1 : MonoBehaviour
{
    
    public float rotateSpeed;
    public GameObject star;

 
    public GameObject camTartget;
    public GameObject CountSystem;
    
    public float camSpeed;
    public float zoomSpeed;
    public float center;

 

    void Start()
    {
        
    }

    void Update()
    {

        //star.GetComponent<CircleMove>().circleMove = true;


        


    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("star"))
        {
            // star.transform.localEulerAngles = new Vector3(0, 0, -90);
            //star.transform.rotation = Quaternion.Euler(0, 0, 270);

            // meet = true;

            star.GetComponent<CircleMove>().rigid.velocity = Vector2.zero;
            star.GetComponent<CircleMove>().circleMove = false;

            Vector3 v3 = this.transform.position - star.transform.position;

            

            camera campoint = GameObject.Find("Main Camera").GetComponent<camera>();
            campoint.target = camTartget;
            
            campoint.target = camTartget; //ī�޶� Ÿ��
            campoint.camwidth = center; // ī�޶� Ŀ���� ����
            campoint.speed = camSpeed; // ī�޶� Ÿ�� �ӵ�
            campoint.zoomSpeed = zoomSpeed; // ī�޶� Ȯ�� �ӵ� 

#if !UNITY_EDITOR
     Vibrate.vibrate((long)100);
#endif



        }
    }

    private void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("star"))
        {
            if (star.GetComponent<CircleMove>().circleMove != true)
            //star.transform.RotateAround(gameObject.transform.position, Vector3.back, rotateSpeed * Time.deltaTime);
            {
                GameObject point = transform.GetChild(0).gameObject;
                star.transform.position = Vector2.MoveTowards(star.transform.position, point.transform.position, rotateSpeed * Time.deltaTime);
                star.transform.rotation = point.transform.rotation;
                star.GetComponent<CircleMove>().PositionSave();
            }


        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        //meet = false;
    }
}
