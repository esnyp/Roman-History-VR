using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameInteractOnTouch : MonoBehaviour
{

    public GameObject numeral1;
    public GameObject hand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(numeral1.transform.position, hand.transform.position);
        Debug.Log("Distance between objects: " + distance);
    }


    

     
}


