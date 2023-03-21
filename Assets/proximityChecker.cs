using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proximityChecker : MonoBehaviour
{
    public GameObject player;
    public float dist;
    public npcDialogueManagement npcDialogueManagement;
    public voiceControlMaster voiceControlMaster;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(transform.position, player.transform.position);
        if (dist < 2.5f)
        {
            npcDialogueManagement.enabled = false;
            voiceControlMaster.enabled = false;
        }
        else { 
        npcDialogueManagement.enabled = true;
        voiceControlMaster.enabled = true;
    }
        Debug.Log(dist);
    }
}
