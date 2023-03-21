using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class settingsButton : MonoBehaviour
{
    public GameObject inventoryButton;
    public GameObject parentSettings;
    public GameObject settingsButton1;
    public TMP_Text heading;

    private string state;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClickToggle()
    {
        if (state == "disabled")
        {
            inventoryButton.SetActive(true);
            state = "enabled";
            heading.text = "";

        }
        else
        {
            inventoryButton.SetActive(false);
            parentSettings.SetActive(true);
            settingsButton1.SetActive(false);
            state = "disabled";
            heading.text = "";
            heading.text = "Settings";

        }
    }
}
