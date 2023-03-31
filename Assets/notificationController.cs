using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class notificationController : MonoBehaviour
{
    public TMP_Text notif; 
    public float fadeTime = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        notif.text = "";
 
    }
    
    public void sendNotification(string notificationMessage)
    {                
        notif.text = notificationMessage;
        StartCoroutine(fadeText());
    }

    IEnumerator fadeText()
    {
        Color selectedColor = notif.color;

        for (float t = fadeTime; t > 0; t -= Time.deltaTime)
        {
            selectedColor.a = t / fadeTime;
            notif.color = selectedColor;
            yield return null;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
