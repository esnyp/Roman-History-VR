using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements.Experimental;

public class menuCanvasController : MonoBehaviour
{
    public GameObject buttonsParent;
    public Canvas settingsCanvas;
    public Button settingsButton;
    public Canvas achievementsCanvas;
    public Button achievementsButton;
    public Canvas questsCanvas;
    public TMP_Text heading;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClickSettings()
    {
        heading.text = "Settings";
        settingsCanvas.gameObject.SetActive(true);
        achievementsCanvas.gameObject.SetActive(false);
        buttonsParent.gameObject.SetActive(false);
    }

    public void OnButtonClickAchievements()
    {
        heading.text = "Achievements";
        settingsCanvas.gameObject.SetActive(false);
        achievementsCanvas.gameObject.SetActive(true);
        buttonsParent.gameObject.SetActive(false);
    }

    public void OnButtonClickQuests()
    {
        heading.text = "Quests";
        settingsCanvas.gameObject.SetActive(false);
        achievementsCanvas.gameObject.SetActive(false);
        questsCanvas.gameObject.SetActive(true);
        buttonsParent.gameObject.SetActive(false);
    }
}
