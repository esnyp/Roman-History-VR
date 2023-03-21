using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class XPBarController : MonoBehaviour
{

    public Slider slider;
    public int playerLevel;
    public TMP_Text levelText;
    public float currentXP;

    private float tarProgress = 0;
    private float XPoverload = 0;
    



    void Start()
    {
        playerLevel = 1;
        slider.minValue = 0;
        slider.maxValue = 200;
        currentXP = 0;
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
            slider.maxValue += 50;
        }
    }

    public void ProgressUpdate(float trackProgress)
    {
        tarProgress = slider.value + trackProgress;
        currentXP = trackProgress;
    }
}
