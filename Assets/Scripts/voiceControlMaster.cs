using Newtonsoft.Json.Bson;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Windows;
using UnityEngine.Windows.Speech;

public class voiceControlMaster : MonoBehaviour
{
    private KeywordRecognizer recog;
    private Dictionary<string, Action> responses = new Dictionary<string, Action>();
    private string selectedNPC;

    public numeralsGameManager numGame1; // access numeral game to enable them after activating
    public numeralsGameManager numGame2;
    public numeralsGameManager numGame3;

    public GameObject questManager;
    public GameObject player;

    public GameObject marcusNPC;
    public GameObject titusNPC;
    public GameObject celiaNPC;
    public GameObject luciusNPC;
    public float distMarcus;
    public float distTitus;
    public float distCelia;
    public float distLucius;

    private void Start()
    {
        responsesDeclaration(); //adds all voice commands
        recog = new KeywordRecognizer(responses.Keys.ToArray());
        recog.OnPhraseRecognized += speechRecognised;
        recog.Start();  
        

    }

    private void Update()
    {
       distMarcus = Vector3.Distance(player.transform.position, marcusNPC.transform.position);
       distTitus = Vector3.Distance(player.transform.position, titusNPC.transform.position);
       distCelia = Vector3.Distance(player.transform.position, celiaNPC.transform.position);
       distLucius = Vector3.Distance(player.transform.position, luciusNPC.transform.position);

        if (distMarcus > 3 && distTitus > 3 && distCelia > 3 && distLucius > 3) //checks if range of any npcs to see if you need to listen for speech
        {
            recog.Stop();
        }
        else
        {
            recog.Start();
        }

        if (distMarcus < 3)
        {
            selectedNPC = "marcusSelected";
        }
        else if (distTitus < 3)
        {
            selectedNPC = "titusSelected";
        }
        else if (distCelia < 3)
        {
            selectedNPC = "celiaSelected";
        }
        else if (distLucius < 3)
        {
            selectedNPC = "luciusSelected";
        }

        /*switch (selectedNPC) // resolved which npc the user is close to
        {
            case "marcusSelected":
               Debug.Log("Marcus Selected");
                break;

            case "titusSelected":
                Debug.Log("Titus Selected");
                break;
            case "celiaSelected":
                Debug.Log("Celia Selected");
                break;
            case "luciusSelected":
                Debug.Log("Lucius Selected");
                break;
            default:
                Debug.Log("Value is something else");
                break;
        }*/


        }

    private void responsesDeclaration() {
        responses.Add("Hello",Greeting);
        responses.Add("Where am I", Location);
        responses.Add("What time is it", Time);
        responses.Add("How is life", HowsLife);
        responses.Add("Do you need help converting these", ConvertingQuest);
        responses.Add("Do you need help?", keyQuest);
        responses.Add("Where could it be?", keyQuestAdd);
        responses.Add("What do you sell", whatDoYouSell);
        responses.Add("Is this your home?", isThisYourHome);
    }

    private void speechRecognised(PhraseRecognizedEventArgs speechDetected)
    {
       // Debug.Log(speechDetected.text);
        responses[speechDetected.text].Invoke();
    }

    private void Greeting()
    {
        if(selectedNPC == "marcusSelected")
        {
            npcDialogueManagement npcdialoguemanagementMarcus = marcusNPC.GetComponent<npcDialogueManagement>();
            npcdialoguemanagementMarcus.dialogueManager(1);
        }
        else if(selectedNPC == "titusSelected")
        {
            npcDialogueManagement npcdialoguemanagementTitus = titusNPC.GetComponent<npcDialogueManagement>();
            npcdialoguemanagementTitus.dialogueManager(7);
        }
        else if (selectedNPC == "celiaSelected")
        {
            npcDialogueManagement npcdialoguemanagementCelia = celiaNPC.GetComponent<npcDialogueManagement>();
            npcdialoguemanagementCelia.dialogueManager(10);
        }
        else if (selectedNPC == "luciusSelected")
        {
            npcDialogueManagement npcdialoguemanagementCelia = luciusNPC.GetComponent<npcDialogueManagement>();
            npcdialoguemanagementCelia.dialogueManager(14);
        }

    }

    private void Location()
    {
        if (selectedNPC == "marcusSelected")
        {
            npcDialogueManagement npcdialoguemanagement = marcusNPC.GetComponent<npcDialogueManagement>();
            npcdialoguemanagement.dialogueManager(2);
        }
    }

    private void Time()
    {
        if (selectedNPC == "marcusSelected")
        {
            npcDialogueManagement npcdialoguemanagement = marcusNPC.GetComponent<npcDialogueManagement>();
            npcdialoguemanagement.dialogueManager(3);
        }
    }

    private void HowsLife()
    {
        if (selectedNPC == "marcusSelected")
        {
            npcDialogueManagement npcdialoguemanagement = marcusNPC.GetComponent<npcDialogueManagement>();
            npcdialoguemanagement.dialogueManager(4);
        }
    }

    private void ConvertingQuest()
    {
        if (selectedNPC == "celiaSelected")
        {
            numGame1.enabled = true;
            numGame2.enabled = true;
            numGame3.enabled = true;

            npcDialogueManagement npcdialoguemanagementCelia = celiaNPC.GetComponent<npcDialogueManagement>();
            npcdialoguemanagementCelia.dialogueManager(11);

            questManager questMan = questManager.GetComponent<questManager>();
            questMan.questResolver(2);
        }
    }

    private void keyQuest()
    {
        if (selectedNPC == "titusSelected")
        {
            npcDialogueManagement npcdialoguemanagementTitus = titusNPC.GetComponent<npcDialogueManagement>();
            questManager questMan = questManager.GetComponent<questManager>();

            questMan.questResolver(1);
            npcdialoguemanagementTitus.dialogueManager(8);
        }
    }

    private void keyQuestAdd()
    {
        if (selectedNPC == "titusSelected")
        {
            npcDialogueManagement npcdialoguemanagementTitus = titusNPC.GetComponent<npcDialogueManagement>();
            questManager questMan = questManager.GetComponent<questManager>();

            npcdialoguemanagementTitus.dialogueManager(9);
        }
    }
    private void whatDoYouSell()
    {
        if (selectedNPC == "celiaSelected")
        {
            npcDialogueManagement npcdialoguemanagementTitus = celiaNPC.GetComponent<npcDialogueManagement>();

            npcdialoguemanagementTitus.dialogueManager(13);
        }
    }

    private void isThisYourHome()
    {
        if (selectedNPC == "titusSelected")
        {
            npcDialogueManagement npcdialoguemanagementTitus = titusNPC.GetComponent<npcDialogueManagement>();    

            npcdialoguemanagementTitus.dialogueManager(5);
        }
    }
}