using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quizGameInteractor : MonoBehaviour
{
    public quizGameManager quizMan;

    public int handSelectedBanner;

    public GameObject player;

    public GameObject banner1;
    public float bannerDist1;
    public GameObject banner2;
    public float bannerDist2;
    public GameObject banner3;
    public float bannerDist3;
    public GameObject banner4;
    public float bannerDist4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        selectedBanner();        
    }

    private int selectedBanner()
    {
        bannerDist1 = Vector3.Distance(banner1.transform.position, player.transform.position);
        bannerDist2 = Vector3.Distance(banner2.transform.position, player.transform.position);
        bannerDist3 = Vector3.Distance(banner3.transform.position, player.transform.position);
        bannerDist4 = Vector3.Distance(banner4.transform.position, player.transform.position);

        if (bannerDist1 < 0.5f)
        {
            handSelectedBanner = 1;
        }
        else if (bannerDist2 < 0.5f)
        {
            handSelectedBanner = 2;
        }
        else if (bannerDist3 < 0.5f)
        {
            handSelectedBanner = 3;
        }
        else if (bannerDist4 < 0.5f)
        {
            handSelectedBanner = 4;
        }

        return handSelectedBanner;
    }

    public void testMessage()
    {
        Debug.Log("test works");
    }
}



