using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPatrol : MonoBehaviour
{

    public Transform[] waypoints; // stores the waypoints in an array
    public int speed;
  //  public float freezeTime = 8f; // controls how long the npc will wait
  //  public GameObject crate;

    private int wayPointIndex; // current waypoint ai is pathing to
    private float dist;
    private bool reachedWaypoint = false; // checks if ai reached checkpoint


    // Start is called before the first frame update
    void Start()
    {
        wayPointIndex = 0;
        transform.LookAt(waypoints[wayPointIndex].position); //makes the ai face the current waypoint stored in wayPintIndex
    }

    // Update is called once per frame
    void Update()
    {
      //  if (reachedWaypoint == true)
       // {
       //     StartCoroutine(patrolFreezer(freezeTime));
        //    return;          
       // }


        dist = Vector3.Distance(transform.position, waypoints[wayPointIndex].position); // checks distance between currently stored waypoint and ai.
                                                                                        // If less than 1 will increase index by 1.
        if(dist < 1f)
        {
            incrementIndex();
        }

        Patrol();
    }

    void Patrol()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);  //
    }

    void incrementIndex()
    {
        wayPointIndex++;
        if(wayPointIndex >= waypoints.Length)
            {
            wayPointIndex = 0;
            }


        transform.LookAt(waypoints[wayPointIndex].position);
        
       // if(wayPointIndex == 5)
      //  {
         //   Debug.Log("At point 5");         
        //    reachedWaypoint = true;
       // }

    }

    IEnumerator patrolFreezer(float sec)
    {     
        yield return new WaitForSeconds(sec);
        reachedWaypoint = false; //resets it
    }
}
