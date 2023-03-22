using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class backButtonSettings : MonoBehaviour
{
    public Canvas settingsCanvas;
    public Button settingsButton;
    public Canvas achievementsCanvas;
    public Button achievementsButton;
    public TMP_Text heading;
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
        heading.text = "";
        settingsCanvas.gameObject.SetActive(false);
        settingsButton.gameObject.SetActive(true);
        achievementsCanvas.gameObject.SetActive(false);
        achievementsButton.gameObject.SetActive(true);
    }
}
