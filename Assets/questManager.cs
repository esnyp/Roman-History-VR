using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEngine.InputManagerEntry;

public class questManager : MonoBehaviour
{
    public XPBarController XP;

    public TMP_Text questTextHUD;
    public TMP_Text extraDialogue;
    public int currentQuestID;
    //
    public TMP_Text questSlot1Title;
    public TMP_Text questSlot1Desc;
    public int questSlot1ID;
    //
    public TMP_Text questSlot2Title;
    public TMP_Text questSlot2Desc;
    public int questSlot2ID;
    //
    public TMP_Text questSlot3Title;
    public TMP_Text questSlot3Desc;
    public int questSlot3ID;
    //
    public TMP_Text questSlot4Title;
    public TMP_Text questSlot4Desc;
    public int questSlot4ID;

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

    private int quest4ID = 4;
    private string quest4Title = "#placeholder";
    private string quest4Desc = "#placeholder desc";
    public Dictionary<int, questData> dictionaryQuests = new Dictionary<int, questData>();

    // Start is called before the first frame update
    void Start()
    {
        extraDialogue.enabled = false;


        dictionaryQuests.Add(1, new questData { questID = quest1ID, questTitle = quest1Title, questDesc = quest1Desc, questCompleted = false });
        dictionaryQuests.Add(2, new questData { questID = quest2ID, questTitle = quest2Title, questDesc = quest2Desc, questCompleted = false });
        dictionaryQuests.Add(3, new questData { questID = quest3ID, questTitle = quest3Title, questDesc = quest3Desc, questCompleted = false });
        dictionaryQuests.Add(4, new questData { questID = quest4ID, questTitle = quest4Title, questDesc = quest4Desc, questCompleted = false });

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(dictionaryQuests[1].questCompleted);
    }

    public struct questData
    {
        public int questID;
        public string questTitle;
        public string questDesc;
        public bool questCompleted;
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
                    updateQuestHUD(id);
                    assignQuestLog(id);                          
                extraDialogue.enabled = true;              
                break;
            case 2:
                   updateQuestHUD(id);
                   assignQuestLog(id);
                break;

            default:
                Debug.Log("No ID");
                break;
        }
    }

    public void updateQuestHUD(int id)
    {
        questTextHUD.text = dictionaryQuests[id].questTitle; ;
    }


    public void assignQuestLog(int id)
    {
        if (questSlot1Title.text.Length == 0)
        {
            questSlot1Title.text = dictionaryQuests[id].questTitle;
            questSlot1Desc.text = dictionaryQuests[id].questDesc;
            questSlot1ID = id;
        }

        else if (questSlot2Title.text.Length == 0)
        {
            questSlot2Title.text = dictionaryQuests[id].questTitle;
            questSlot2Desc.text = dictionaryQuests[id].questDesc;
            questSlot2ID = id;
        }

        else if (questSlot3Title.text.Length == 0)
        {
            questSlot3Title.text = dictionaryQuests[id].questTitle;
            questSlot3Desc.text = dictionaryQuests[id].questDesc;
            questSlot3ID = id;
        }

        else if (questSlot4Title.text.Length == 0)
        {
            questSlot4Title.text = dictionaryQuests[id].questTitle;
            questSlot4Desc.text = dictionaryQuests[id].questDesc;
            questSlot3ID = id;
        }
        else
        {
            Debug.Log("Quest log full");
        }
    }

    public void questCompleter(int id)
    {
        dictionaryQuests[id] = new questData { questID = id, questTitle = dictionaryQuests[id].questTitle, questDesc = dictionaryQuests[id].questDesc, questCompleted = true };
        XP.ProgressUpdate(200.0f);

        if (questSlot1ID == id)
        {
            questSlot1Title.color = Color.green;
            questSlot1Desc.color = Color.green;
        }
        else if(questSlot2ID == id)
        {
            questSlot2Title.color = Color.green;
            questSlot2Desc.color = Color.green;
        }
        else if (questSlot3ID == id)
        {
            questSlot3Title.color = Color.green;
            questSlot3Desc.color = Color.green;
        }
        else if (questSlot4ID == id)
        {
            questSlot4Title.color = Color.green;
            questSlot4Desc.color = Color.green;
        }
    }
}
