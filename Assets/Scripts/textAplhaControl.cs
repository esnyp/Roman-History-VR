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
    public TMP_Text text;

    private void Awake()
    {
       
    }

    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
        distBetweenObj = Vector3.Distance(transform.position, obj.transform.position);

        if (distBetweenObj < 0.8 == true)
        {
            text.faceColor = new Color32(255, 255, 255, 255);
        }
        else
        {
            text.faceColor = new Color32(255, 255, 255, 0);
        }                 
    }

}
