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
    private String speechGreetingMarcus = "Hail"; // Marcus
    private String speechLocationMarcus = "You're in Caerulia! A small trading town in the outskirts of Rome"; // Marcus
    private String speechHelpMarcus = "There are people by the market which may need help. The market is just behind you!"; // Marcus
    private String speechHowsLifeMarcus = "Life for peasants in Rome was extremely difficult." + // Marcus
        " Most of us worked as farmers, caring for crops and livestock." +
        " We also had to pay many taxes and provide free labor for construction projects.";

    private String speechQuest = "In Rome we use Roman numerals such as IV to represent the value 4 and XII to " +
        "represent the value seven. I was trying to setup my market stand but accidently purchased these Arabic numerals! Can you" +
        "help me convert them?";
    private String speechGreetingTitus = "Hail";
    private String speechQuestTitus = "(Quest) I can't find the key to my house! Can you help me find it? The last time I saw it was " +
        "near the well at the market";

   
    public void dialogueManager(int dialogueID)
    {
        {
            switch (dialogueID)
            {
                case 1:
                    Debug.Log(speechGreetingMarcus);
                    NPCtext.text = speechGreetingMarcus;
                    break;
                case 2:
                    Debug.Log(speechLocationMarcus);
                    NPCtext.text = speechLocationMarcus;
                    break;
                case 3:
                    Debug.Log(speechHelpMarcus);
                    NPCtext.text = speechHelpMarcus;
                    break;
                case 4:
                    Debug.Log(speechHowsLifeMarcus);
                    NPCtext.text = speechHowsLifeMarcus;
                    break;
                case 5:
                    Debug.Log(speechGreetingTitus);
                    NPCtext.text = speechQuest;
                    break;
                case 6:
                    Debug.Log(speechQuestTitus);
                    NPCtext.text = speechQuest;
                    break;
             

                default:
                    Debug.Log("Value is something else");
                    break;
            }
        }
    }
}
