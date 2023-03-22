using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class achievementColliderExploreHouse : MonoBehaviour
{
    public GameObject player;
    public GameObject achievementManager;
    public GameObject notificationManager;

    private achievementColliderExplore achievementcoliderexplore;
    private notificationController notificationcontroller;

    // Start is called before the first frame update
    void Start()
    {
        achievementcoliderexplore = achievementManager.GetComponent<achievementColliderExplore>();
        notificationcontroller = notificationManager.GetComponent<notificationController>();
    }

    // Update is called once per frame
    void Update()
    {
        //  Debug.Log(achievementcoliderexplore.templeC);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            notificationcontroller.sendNotification("Titus's House");
            achievementcoliderexplore.houseC = 1;
        }
    }
}
