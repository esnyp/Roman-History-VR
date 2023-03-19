using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPBarController : MonoBehaviour
{

    public Slider slider;
    public ParticleSystem partSys;

    private float tarProgress = 0;

    // Start is called before the first frame update

    private void Awake()
    {
        
    }

    void Start()
    {
        ProgressUpdate(0.75f);
    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < tarProgress)
        {
            slider.value += 0.1f * Time.deltaTime;
            if (!partSys.isPlaying)
            {
                partSys.Play();
            }
        }
        else
        {
            partSys.Stop();
        }
    }

    public void ProgressUpdate(float trackProgress)
    {
        tarProgress = slider.value + trackProgress;
    }
}
