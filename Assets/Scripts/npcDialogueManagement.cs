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
    private String speechGreeting = "Hail"; // Marcus + Titus
    private String speechLocation = "You're in Rome!"; // Marcus
    private String speechTime = "The year is currently 44BC"; // Marcus
    private String speechHowsLife = "Life for peasants in Rome was extremely difficult." + // Marcus
        " Most of us worked as farmers, caring for crops and livestock." +
        " We also had to pay many taxes and provide free labor for construction projects.";

    private String speechQuest = "In Rome we use Roman numerals such as IV to represent the value 4 and XII to " +
        "represent the value seven. I was trying to setup my market stand but accidently purchased these Arabic numerals! Can you" +
        "help me convert them?";
 

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
                case 5:
                    Debug.Log(speechQuest);
                    NPCtext.text = speechQuest;
                    break;

                default:
                    Debug.Log("Value is something else");
                    break;
            }
        }
    }
}
