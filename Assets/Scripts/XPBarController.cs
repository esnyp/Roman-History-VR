using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class XPBarController : MonoBehaviour
{

    public Slider slider;
    public ParticleSystem partSys;
    public int playerLevel;
    public TMP_Text levelText;
    public int currentXP;

    private float tarProgress = 0;


    // Start is called before the first frame update

    private void Awake()
    {
        playerLevel = 1;     
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        levelText.text = "Level: " + playerLevel;

        if (slider.value < tarProgress)
        {
            slider.value += 0.5f * Time.deltaTime;           
        }
        

        if (slider.value == 1.0f)
        {
            slider.value = 0.0f;
            playerLevel++;
        }
    }

    public void ProgressUpdate(float trackProgress)
    {
        tarProgress = slider.value + trackProgress;
    }
}
