using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class playerTeleporter : MonoBehaviour
{
    private float playerDist;
    private int checker = 0;

    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        playerDist = Vector3.Distance(player.transform.position, transform.position);

      
        
        if(playerDist < 5 && checker < 1)
        {
            player.transform.position = new Vector3(261f, 3f, 34f);
            checker++;
        }

    }

    

}
