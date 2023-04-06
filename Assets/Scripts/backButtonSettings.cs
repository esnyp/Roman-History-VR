using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class backButtonSettings : MonoBehaviour
{
    public Canvas settingsCanvas;
    public Canvas achievementsCanvas;
    public Canvas questsCanvas;
    public TMP_Text heading;
    public GameObject buttonsParent;
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
        achievementsCanvas.gameObject.SetActive(false);
        questsCanvas.gameObject.SetActive(false);
        buttonsParent.gameObject.SetActive(true);
        
    }
}
