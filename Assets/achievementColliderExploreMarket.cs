using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class achievementColliderExploreMarket : MonoBehaviour
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
      //  Debug.Log(achievementcoliderexplore.marketC);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            achievementcoliderexplore.marketC = 1;
        }
    }
}
