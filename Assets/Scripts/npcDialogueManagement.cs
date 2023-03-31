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
    public GameObject npc;

    private int dialogueID;
    private String speechGreetingMarcus = "Hail, I am Marcus"; // Marcus
    private String speechLocationMarcus = "You're in Caerulia! A small trading town in the outskirts of Rome"; // Marcus
    private String speechHelpMarcus = "There are people by the market which may need help. The market is just behind you!"; // Marcus
    private String speechHowsLifeMarcus = "Life for peasants in Rome was extremely difficult." + // Marcus
        " Most of us worked as farmers, caring for crops and livestock." +
        " We also had to pay many taxes and provide free labor for construction projects.";
    private String speechGreetingTitus = "Hail, I am Titus";
    private String speechKeyTitus = "(QUEST) I'm stuck out here because I lost the key to my home! Can you help me find it?";
    private String speechKeyTitusAdd = "(QUEST) I was at the market earlier so I'd start there!";
    private String speechHomeTitus = "There are four types of homes people generally live in. The Domus for the wealthiest people. The Insulae" +
        "for merchants and working people. Villas for wealthy people outside the town and farm houses for people living in the countryside.";
    private String speechGreetingCelia = "Hail, I am Celia";
    private String speechConvertCelia = "(QUEST) I purchased these banners for my market stand but they're using arabic numerals! " +
        "Merchants generally use Roman numerals and I don't understsand these arabic ones. Can you help convert these for me?";
    private String speechTipCelia = "Hmm, I think I remember seeing a key by the well.";
    private String speechSellCelia = "I usually sell metalwork and tableware but other merchants commonly sell stuff such as clothing, textiles, food, beverages, and pottery";
    private String speechGreetingLucius = "Hail, I am Lucius";


    public void dialogueManager(int dialogueID)
    {
        {
          //  Debug.Log(gameObject.name);
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
                    Debug.Log(speechHomeTitus);
                    NPCtext.text = speechHomeTitus;
                    break;             
                case 7:
                    Debug.Log(speechGreetingTitus);
                    NPCtext.text = speechGreetingTitus;
                    break;
                case 8:
                    Debug.Log(speechKeyTitus);
                    NPCtext.text = speechKeyTitus;
                    break;
                case 9:
                    Debug.Log(speechKeyTitusAdd);
                    NPCtext.text = speechKeyTitusAdd;
                    break;
                case 10:
                    Debug.Log(speechGreetingCelia);
                    NPCtext.text = speechGreetingCelia;
                    break;
                case 11:
                    Debug.Log(speechConvertCelia);
                    NPCtext.text = speechConvertCelia;
                    break;
                case 12:
                    Debug.Log(speechTipCelia);
                    NPCtext.text = speechTipCelia;
                    break;
                case 13:
                    Debug.Log(speechSellCelia);
                    NPCtext.text = speechSellCelia;
                    break;
                case 14:
                    Debug.Log(speechGreetingLucius);
                    NPCtext.text = speechGreetingLucius;
                    break;


                default:
                    Debug.Log("Value is something else");
                    break;
            }
        }
    }
}
