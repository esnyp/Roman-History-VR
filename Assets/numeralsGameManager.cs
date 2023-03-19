using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class numeralsGameManager : MonoBehaviour
{
    public GameObject numeral1;
    public GameObject numeral2;
    public GameObject numeral3;
    public GameObject hand;
    public string selectedBanner;
    public Material newMat;

    private Renderer cubeRender1;
    private Renderer cubeRender2;
    private Renderer cubeRender3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cubeRender1 = numeral1.GetComponent<Renderer>();
        cubeRender2 = numeral2.GetComponent<Renderer>();
        cubeRender3 = numeral3.GetComponent<Renderer>();

        float distanceNum1 = Vector3.Distance(numeral1.transform.position, hand.transform.position);
        float distanceNum2 = Vector3.Distance(numeral2.transform.position, hand.transform.position);
        float distanceNum3 = Vector3.Distance(numeral3.transform.position, hand.transform.position); 
        
        if(distanceNum1 < 0.2)
        {
            num1Selected();
        }
        else if(distanceNum2 < 0.2)
        {
            num2Selected();
        }
        else if (distanceNum3 < 0.2)
        {
            num3Selected();
        }
    }

    void num1Selected()
    {
        selectedBanner = "banner1";
        cubeRender1.material.color = Color.green;
        enabled = false;
    }

    void num2Selected()
    {
        selectedBanner = "banner2";
        cubeRender2.material.color = Color.green;
        enabled = false;
    }
    void num3Selected()
    {
        selectedBanner = "banner3";
        cubeRender3.material.color = Color.green;
        enabled = false;
    }


}
