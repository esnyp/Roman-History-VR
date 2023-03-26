using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.InputManagerEntry;

public class questManager : MonoBehaviour
{
    public TMP_Text questTextHUD;
    public TMP_Text extraDialogue;
    public int currentQuestID;
    //
    public TMP_Text questSlot1Title;
    public TMP_Text questSlot1Desc;
    public bool questSlot1OnQuest;
    //
    public TMP_Text questSlot2Title;
    public TMP_Text questSlot2Desc;
    public bool questSlot2OnQuest;
    //
    public TMP_Text questSlot3Title;
    public TMP_Text questSlot3Desc;
    public bool questSlot3OnQuest;
    //
    public TMP_Text questSlot4Title;
    public TMP_Text questSlot4Desc;
    public bool questSlot4OnQuest;

    // Quest Descriptions

    private int quest1ID = 1;
    private string quest1Title = "Find Titus's key!";
    private string quest1Desc = "Titus lost his key so now he's stuck outside. He recommended you start searching around the market since thats where he last was";

    private int quest2ID = 2;
    private string quest2Title = "Convert the Numerals!";
    private string quest2Desc = "Celia purchased the wrong banners. Help her convert the arabic numerals into Roman ones!";

    private int quest3ID = 3;
    private string quest3Title = "Investigate the disturbance in the forest!";
    private string quest3Desc = "Lucius heard a loud noise in the forest. Go and check it out!";

    private int quest4ID;
    private string quest4Title;
    private string quest4Desc;


    // Start is called before the first frame update
    void Start()
    {
        extraDialogue.enabled = false;
        Dictionary<int, questData> dictionaryQuests = new Dictionary<int, questData>();

        dictionaryQuests.Add(1, new questData { questID = quest1ID, questTitle = quest1Title, questDesc = quest1Desc });

      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public struct questData
    {
        public int questID;
        public string questTitle;
        public string questDesc;
    }

    public void questResolver(int id) // assigns the current quest ID and calls the method to change the quesdt canvas text
    {
        switch (id) {
            case 1:
                currentQuestID = id;
                questAssigner(id);
                break;
            case 2:
                currentQuestID = id;
                questAssigner(id);
                break;
            default:
                Debug.Log("No ID");
                break;

        }  
    }

    public void questAssigner(int id)
    {
        switch (id)
        {
            case 1:
                if (!questTextHUD.text.Contains("Find Titus's key!"))
                {
                    questTextHUD.text += " Find Titus's key!";                    
                }            
                extraDialogue.enabled = true;
                Debug.Log(questTextHUD.text.Contains("Find"));
                break;
            case 2:
                questTextHUD.text += " Help convert the numerals!";
                Debug.Log("quest accepted" + id);
                break;
            default:
                Debug.Log("No ID");
                break;
        }
    }


    public void assignQuestLog(int id)
    {
        if (questSlot1Title.text.Length == 0)
        {
            questSlot1Title.text = "Find Titus's key!";
            questSlot1Desc.text = quest1Desc;
            questSlot1OnQuest = true;
        }

        else if (questSlot2Title.text.Length == 0)
        {
            questSlot2Title.text = "Find Titus's key!";
            questSlot2Desc.text = quest1Desc;
            questSlot2OnQuest = true;
        }

        else if (questSlot3Title.text.Length == 0)
        {
            questSlot3Title.text = "Find Titus's key!";
            questSlot3Desc.text = quest1Desc;
            questSlot3OnQuest = true;
        }

        else if (questSlot4Title.text.Length == 0)
        {
            questSlot4Title.text = "Find Titus's key!";
            questSlot4Desc.text = quest1Desc;
            questSlot4OnQuest = true;
        }
    }
}
