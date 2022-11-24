using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstSatellite : MonoBehaviour
{

    //public GameObject target;
    float rotate;
    public GameObject planet1;

    private void Awake()
    {
        
        if (planet1) {
            rotate = planet1.GetComponent<start>().rotateSpeed;
        }

    }

    void Update()
    {
        
        if (planet1) {
            transform.RotateAround(planet1.transform.position, Vector3.back, rotate * Time.deltaTime);
        }
        
    }
}
