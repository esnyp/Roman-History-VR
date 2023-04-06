using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class XPBarController : MonoBehaviour
{

    public Slider slider;
    public int playerLevel;
    public TMP_Text levelText;
    public float currentXP;


    private float tarProgress = 0;
    private XROrigin xrOrigin;
    void Start()
    {
        playerLevel = 1;
        slider.minValue = 0;
        slider.maxValue = 200;
        currentXP = 0;
        xrOrigin = FindObjectOfType<XROrigin>();
    }
    // Update is called once per frame
    void Update()
    {
        levelText.text = "Level: " + playerLevel;
        

        if (slider.value < tarProgress)
        {
            slider.value += 1.5f * Time.deltaTime*50;
            tarProgress--;
        }

        if (slider.value >= slider.maxValue)
        {
            tarProgress = tarProgress - currentXP; 
            slider.value = 0.0f;
            playerLevel++;
            xrOrigin.GetComponentInChildren<ActionBasedContinuousMoveProvider>().moveSpeed =
            (xrOrigin.GetComponentInChildren<ActionBasedContinuousMoveProvider>().moveSpeed) * 1.2f; // player gains 20% movement speed everytime they level up
            slider.maxValue += 50;
        }
    }
    public void ProgressUpdate(float trackProgress)
    {       
        tarProgress = slider.value + trackProgress;
        currentXP = trackProgress;
    }
}
