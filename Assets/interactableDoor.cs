using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class interactableDoor : MonoBehaviour
{
    public GameObject titusNPC;
    public GameObject door;


    private float tarRotate = 270.0f;
    private bool doorOpen = false;

    //private bool doorLock = false;


    public void doorOpener()
    { 
            door.transform.Rotate(0, tarRotate, 0, Space.World);
            doorOpen = true;                         
    }
    

    private void Update()
    {
        
    }

    private void rotateDoor(float num)
    {

    }

    
}
