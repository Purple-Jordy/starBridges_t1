using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleTarget : MonoBehaviour
{
    public GameObject panel;
    public GameObject star;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnBecameInvisible()
    {
        star.GetComponent<CircleMove>().rigid.velocity = Vector2.zero;
        star.GetComponent<CircleMove>().circleMove = false;
        star.SetActive(false);
        if (panel)
        {
            panel.SetActive(true);
        }
            

    }



}
