using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactableDoor : MonoBehaviour
{
    public GameObject key;


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == key)
        {
            Debug.Log("Key HIT!");
        }
    }
}
