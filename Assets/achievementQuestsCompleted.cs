using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class achievementQuestsCompleted : MonoBehaviour
{
    public questManager questMan;
    public GameObject notificationManager;
    public TMP_Text achievementTitle;
    public TMP_Text subTitles1;
    public TMP_Text subTitles2;

    private notificationController notificationcontroller;
    private int questChecker;
    private bool questIDCompleted1 = false;
    private bool questIDCompleted2 = false;


    // Start is called before the first frame update
    void Start()
    {
        notificationcontroller = notificationManager.GetComponent<notificationController>();
    }

    // Update is called once per frame
    void Update()
    {
        questIDCompleted1 = questMan.dictionaryQuests[1].questCompleted;
        questIDCompleted2 = questMan.dictionaryQuests[2].questCompleted;

        if (questIDCompleted2 == true)
        {
            subTitles1.text = "Complete Celia's quest (complete)";
            subTitles1.color = Color.green;
        }
        if (questIDCompleted1 == true)
        {
            subTitles2.text = "Complete Marcus's quest (complete)";
            subTitles2.color = Color.green;
        }


        if (questIDCompleted1 == true && questIDCompleted2 == true) {
            notificationcontroller.sendNotification("You've completed the achievement | Complete quests! |");
            achievementTitle.text = "Complete the following quests (complete)";
            achievementTitle.color = Color.green;
        }

    }
}
