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
    public TMP_Text subAchievement0;
    public TMP_Text subAchievement1;
    public TMP_Text subAchievement2;
    public int templeC = 0;
    public int marketC = 0;

    // Start is called before the first frame update
    void Start()
    {       
        
    }

    // Update is called once per frame
    void Update()
    {
        awardAchievement();
        awardSubAchievement();
    }

    public void awardAchievement()
    {
        if(templeC + marketC == 2)
        {
       //     Debug.Log("achieved");
        }
        else
        {
       //     Debug.Log("not achieved");
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
    }

}
