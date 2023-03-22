using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class achievementColliderExploreHouse : MonoBehaviour
{
    public GameObject player;
    public GameObject achievementManager;
    private achievementColliderExplore achievementcoliderexplore;


    // Start is called before the first frame update
    void Start()
    {
        achievementcoliderexplore = achievementManager.GetComponent<achievementColliderExplore>();
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
            achievementcoliderexplore.houseC = 1;
        }
    }
}
