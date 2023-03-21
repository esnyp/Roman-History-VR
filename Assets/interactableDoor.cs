using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactableDoor : MonoBehaviour
{
    public GameObject key;
    public GameObject door;

    private bool doorLock = false;


   private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == key)
        {
            Debug.Log("its da key");
        }
        else
        {
            Debug.Log("it aint da key");
        }
    }

    
}
