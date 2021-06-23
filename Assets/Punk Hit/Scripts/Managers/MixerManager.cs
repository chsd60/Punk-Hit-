using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixerManager : MonoBehaviour {

    public AudioMixer masterMixer;
    
    public void SetVolume(float sliderValue) {
        masterMixer.SetFloat("masterVol", Mathf.Log10(sliderValue) * 20);
    }
}
