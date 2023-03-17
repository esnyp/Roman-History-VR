using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPatrol : MonoBehaviour
{

    public Transform[] waypoints;
    public int speed;


    private int wayPointIndex;
    private float dist;
    // Start is called before the first frame update
    void Start()
    {
        wayPointIndex = 0;
        transform.LookAt(waypoints[wayPointIndex].position);
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(transform.position, waypoints[wayPointIndex].position);
        if(dist < 1f)
        {
            IncreaseIndex();
        }

        Patrol();
    }

    void Patrol()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void IncreaseIndex()
    {
        wayPointIndex++;
        if(wayPointIndex >= waypoints.Length)
            {
            wayPointIndex = 0;
            }
        transform.LookAt(waypoints[wayPointIndex].position);
        

    }
}
