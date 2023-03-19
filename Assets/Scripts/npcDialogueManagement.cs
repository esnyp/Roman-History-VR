using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class npcDialogueManagement : MonoBehaviour
{

    public float distToPlayer;
    public GameObject playerObj;
    public TMP_Text NPCtext;



    private int dialogueID;

    private String speechGreeting = "Hail"; // Marcus
    private String speechLocation = "You're in Rome!"; // Marcus


    private String speechTime = "The year is currently 44BC"; // Titus
    private String speechHowsLife = "Life for peasants in Rome was extremely difficult." + // Titus
        " Most of us worked as farmers, caring for crops and livestock." +
        " We also had to pay many taxes and provide free labor for construction projects.";

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    

    public void dialogueManager(int dialogueID)
    {
        {
            switch (dialogueID)
            {
                case 1:
                    Debug.Log(speechGreeting);
                    NPCtext.text = speechGreeting;
                    break;
                case 2:
                    Debug.Log(speechLocation);
                    NPCtext.text = speechLocation;
                    break;
                case 3:
                    Debug.Log(speechTime);
                    NPCtext.text = speechTime;
                    break;
                case 4:
                    Debug.Log(speechHowsLife);
                    NPCtext.text = speechHowsLife;
                    break;
                default:
                    Debug.Log("Value is something else");
                    break;
            }
        }
    }
}
