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
    public GameObject NPC;

    private void Start()
    {
        responsesDeclaration(); //adds all voice commands
        recog = new KeywordRecognizer(responses.Keys.ToArray());
        recog.OnPhraseRecognized += speechRecognised;
        recog.Start();       
    }

    private void responsesDeclaration() {
        responses.Add("Hello",Greeting);
        responses.Add("Where am I?", Location);
        responses.Add("What time is it?", Time);
        responses.Add("How is life?", HowsLife);
    }

    private void speechRecognised(PhraseRecognizedEventArgs speechDetected)
    {
       // Debug.Log(speechDetected.text);
        responses[speechDetected.text].Invoke();
    }

    private void Greeting()
    {
        npcDialogueManagement npcdialoguemanagement = NPC.GetComponent<npcDialogueManagement>();
        npcdialoguemanagement.dialogueManager(1);        
    }

    private void Location()
    {
        npcDialogueManagement npcdialoguemanagement = NPC.GetComponent<npcDialogueManagement>();
        npcdialoguemanagement.dialogueManager(2);
    }

    private void Time()
    {
        npcDialogueManagement npcdialoguemanagement = NPC.GetComponent<npcDialogueManagement>();
        npcdialoguemanagement.dialogueManager(3);
    }

    private void HowsLife()
    {
        npcDialogueManagement npcdialoguemanagement = NPC.GetComponent<npcDialogueManagement>();
        npcdialoguemanagement.dialogueManager(4);
    }

}