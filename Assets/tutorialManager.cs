using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tutorialManager : MonoBehaviour
{
    //Buttons
    public Button startButton;
    public GameObject Tut1Parent;
    public GameObject Tut2Parent;
    public GameObject Tut3Parent;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickStartButton()
    {
        Tut1Parent.gameObject.SetActive(false);
    }

    public void OnClickTut2Button()
    {
        Tut2Parent.gameObject.SetActive(false);
    }

    public void OnClickTut3Button()
    {
        Tut3Parent.gameObject.SetActive(false);
        player.transform.position = new Vector3(261f, 3f, 34f);
    }
}
