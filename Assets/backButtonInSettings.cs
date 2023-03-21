using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class backButtonInSettings : MonoBehaviour
{
    public GameObject settingsParent;
    public GameObject inventoryButton;
    public GameObject settingsButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClick()
    {
        settingsParent.SetActive(false);
        inventoryButton.SetActive(true);
        settingsButton.SetActive(true);
    }
}
