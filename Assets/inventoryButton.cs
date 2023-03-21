using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class inventoryButton : MonoBehaviour
{
    public GameObject settingsButton;
    public TMP_Text heading;

    private string state;

    private void Awake()
    {
        state = "disabled";
    }

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
        if(state == "disabled")
        {
            settingsButton.SetActive(true);
            state = "enabled";
            heading.text = "";
            
        }
        else
        {
            settingsButton.SetActive(false);
            state = "disabled";
            heading.text = "";
            heading.text = "Inventory";
        }
    }
}
