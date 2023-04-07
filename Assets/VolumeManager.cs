using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
    public Slider volSlider;
    public void ChangeVolume()
    {
        AudioListener.volume = volSlider.value;
    }
}
