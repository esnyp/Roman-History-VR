using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements.Experimental;

public class menuCanvasController : MonoBehaviour
{
    public Button abandonButton1;
    public TMP_Text questSlot1Title;
    public TMP_Text questSlot1Desc;
    public int questSlot1ID;
    //
    public Button abandonButton2;
    public TMP_Text questSlot2Title;
    public TMP_Text questSlot2Desc;
    public int questSlot2ID;
    //
    public Button abandonButton3;
    public TMP_Text questSlot3Title;
    public TMP_Text questSlot3Desc;
    public int questSlot3ID;
    //
    public Button abandonButton4;
    public TMP_Text questSlot4Title;
    public TMP_Text questSlot4Desc;
    public int questSlot4ID;

    public GameObject buttonsParent;
    public Canvas settingsCanvas;
    public Button settingsButton;
    public Canvas achievementsCanvas;
    public Button achievementsButton;
    public Canvas questsCanvas;
    public TMP_Text heading;

  //  public GameObject questManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (questSlot1Title.text.Length > 0)
        {
            abandonButton1.gameObject.SetActive(true);
        }

        if (questSlot2Title.text.Length > 0)
        {
            abandonButton2.gameObject.SetActive(true);
        }

        if (questSlot3Title.text.Length > 0)
        {
            abandonButton3.gameObject.SetActive(true);
        }

        if (questSlot4Title.text.Length > 0)
        {
            abandonButton4.gameObject.SetActive(true);
        }

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

    public void OnClickTest()
    {
  //      questManager questMan = questManager.GetComponent<questManager>();
 //       questMan.questCompleter(1);
    }

    public void OnButtonClickAbandonQuest1()
    {
        abandonButton1.gameObject.SetActive(false);
        questSlot1Desc.text = "";
        questSlot1Title.text = "";
        questSlot1ID = 0;
    }

    public void OnButtonClickAbandonQuest2()
    {
        abandonButton2.gameObject.SetActive(false);
        questSlot2Desc.text = "";
        questSlot2Title.text = "";
        questSlot2ID = 0;
    }

    public void OnButtonClickAbandonQuest3()
    {
        abandonButton3.gameObject.SetActive(false);
        questSlot3Desc.text = "";
        questSlot3Title.text = "";
        questSlot3ID = 0;
    }

    public void OnButtonClickAbandonQuest4()
    {
        abandonButton4.gameObject.SetActive(false);
        questSlot4Desc.text = "";
        questSlot4Title.text = "";
        questSlot4ID = 0;
    }


}
