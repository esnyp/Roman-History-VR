using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proximityChecker : MonoBehaviour
{
    public GameObject player;
    public float dist;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(transform.position, player.transform.position);
        Debug.Log(dist);
    }
}
