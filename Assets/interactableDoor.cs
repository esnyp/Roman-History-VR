using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class interactableDoor : MonoBehaviour
{
    public GameObject key;
    public GameObject door;
    public GameObject questManager;

    private float tarRotate = 270.0f;
    private bool doorOpen = false;

    //private bool doorLock = false;


   private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == key && doorOpen == false)
        {
            door.transform.Rotate(0, tarRotate, 0, Space.World);
            doorOpen = true;

            questManager questMan = questManager.GetComponent<questManager>();
            questMan.questCompleter(1);
        }
        else
        {
            Debug.Log("it aint da key");
        }
    }

    private void Update()
    {
        
    }

    private void rotateDoor(float num)
    {

    }

    
}
