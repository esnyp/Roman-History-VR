using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class questManager : MonoBehaviour
{
    public TMP_Text questText;
    public TMP_Text extraDialogue;
    public int currentQuestID;
    

    // Start is called before the first frame update
    void Start()
    {
        extraDialogue.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void questResolver(int id)
    {
        switch (id) {
            case 1:
                currentQuestID = id;
                questAssigner(id);
                break;
            case 2:
                currentQuestID = id;
                questAssigner(id);
                break;
            default:
                Debug.Log("No ID");
                break;

        }  
    }

    public void questAssigner(int id)
    {
        switch (id)
        {
            case 1:
                if (!questText.text.Contains("Find Titus's key!"))
                {
                    questText.text += " Find Titus's key!";
                }
                    extraDialogue.enabled = true;
                Debug.Log(questText.text.Contains("Find"));
                break;
            case 2:
                questText.text += " Help convert the numerals!";
                Debug.Log("quest accepted" + id);
                break;
            default:
                Debug.Log("No ID");
                break;
        }
    }
}
