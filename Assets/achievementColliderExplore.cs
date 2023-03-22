using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class achievementColliderExplore : MonoBehaviour
{
    public GameObject templeCollider;
    public GameObject marketCollider;
    public GameObject player;
    public GameObject notificationManager;
    public TMP_Text achievementTitle;
    public TMP_Text subAchievement0;
    public TMP_Text subAchievement1;
    public TMP_Text subAchievement2;
    public int templeC = 0;
    public int marketC = 0;
    public int houseC = 0;
    public bool achievementAchieved = false;

    private notificationController notificationcontroller;


    // Start is called before the first frame update
    void Start()
    {
        notificationcontroller = notificationManager.GetComponent<notificationController>();
    }

    // Update is called once per frame
    void Update()
    {
        awardAchievement();
        awardSubAchievement();
    }

    public void awardAchievement()
    {
        if(templeC + marketC + houseC == 3)
        {
            notificationcontroller.sendNotification("You've completed the achievement | Explore Caerulia |");
            achievementAchieved = true;
            achievementTitle.color = Color.green;
            achievementTitle.text = "Explore Caerulia (complete)";
        }
    }

    public void awardSubAchievement()
    {
        if(templeC == 1)
        {
            subAchievement0.text = "Explore the Temple (comeplete)";
            subAchievement0.color = Color.green;
        }
        if (marketC == 1)
        {
            subAchievement1.text = "Explore the Market (comeplete)";
            subAchievement1.color = Color.green;
        }
        if (houseC == 1)
        {
            subAchievement2.text = "Explore a house (comeplete)";
            subAchievement2.color = Color.green;
        }
    }

}
