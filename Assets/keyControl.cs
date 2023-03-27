using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;

public class keyControl : MonoBehaviour
{
    public GameObject key;
    public GameObject titusNPC;
    public TMP_Text dialogueBoxText;
    public GameObject questManager;
    public GameObject doorScript;

    private string questCompleteText = "Thank you! Now I can finnaly get in my house! Feel free to help yourself to any food inside!";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == key)
        {          
            questManager questMan = questManager.GetComponent<questManager>();
            AIPatrol aipat = titusNPC.GetComponent<AIPatrol>();
            interactableDoor intDoor = doorScript.GetComponent<interactableDoor>();

            StartCoroutine(openDoorDelay());         
            Destroy(key);
            questMan.questCompleter(1);
            dialogueBoxText.text = questCompleteText;
            aipat.enabled = true;
        }
    }

    IEnumerator openDoorDelay()
    {
        yield return new WaitForSeconds(4.5f);

        interactableDoor intDoor = doorScript.GetComponent<interactableDoor>();
        intDoor.doorOpener();
    }
}

