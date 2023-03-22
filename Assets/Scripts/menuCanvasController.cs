using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements.Experimental;

public class menuCanvasController : MonoBehaviour
{
    public Canvas settingsCanvas;
    public Button settingsButton;
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
        settingsButton.gameObject.SetActive(false);
    }
}
