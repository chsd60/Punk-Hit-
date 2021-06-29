using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MixerManager : MonoBehaviour {

    public AudioMixer masterMixer;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void SetVolume(float sliderValue) {
        masterMixer.SetFloat("masterVol", Mathf.Log10(sliderValue) * 20);
    }
}
