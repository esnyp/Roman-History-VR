using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textAplhaControl : MonoBehaviour
{
    // Start is called before the first frame update

    public float distBetweenObj;
    public GameObject obj;
    public Canvas canvas;

    private void Awake()
    {
       
    }

    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

        //  Debug.Log(distBetweenObj = Vector3.Distance(transform.position, obj.transform.position));

        distBetweenObj = Vector3.Distance(obj.transform.position, canvas.transform.position);

        if (distBetweenObj < 5 == true)
        {
            canvas.enabled = true;
        }
        else
        {
            canvas.enabled = false;
        }                 
    }

}
