using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class textAplhaControl : MonoBehaviour
{
    // Start is called before the first frame update

    public float distBetweenObj;
    public GameObject player;
    public GameObject NPC;
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

        distBetweenObj = Vector3.Distance(player.transform.position, NPC.transform.position);

        if (distBetweenObj < 3 == true)
        {
            canvas.enabled = true;
        }
        else
        {
            canvas.enabled = false;
        }                 
    }

}
