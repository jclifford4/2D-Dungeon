using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class VolumeSliderScript : MonoBehaviour
{
    Slider musicVolumeSlider, sfxVolumeSlider;
    public TMP_Text txt_volumeValue, txt_sfx_volume;
    private static float curMusVolume, curSFXvolume;
    


    // Start is called before the first frame update
    void Start()
    {
        musicVolumeSlider.minValue = 0.01f;
        musicVolumeSlider.maxValue = 1.0f;
        musicVolumeSlider.value = .5f;

        sfxVolumeSlider.minValue = 0.01f;
        sfxVolumeSlider.maxValue = 1.0f;
        sfxVolumeSlider.value = .5f;

     


    }

    private void Awake()
    {
        musicVolumeSlider = GameObject.Find("VolumeSlider").GetComponent<Slider>();
        txt_volumeValue = GameObject.Find("txt_volume").GetComponent<TMP_Text>();

        sfxVolumeSlider = GameObject.Find("VolumeSlider_sfx").GetComponent<Slider>();
        txt_sfx_volume = GameObject.Find("txt_sfx_volume").GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        curMusVolume = Mathf.Round(musicVolumeSlider.value * 100);
        txt_volumeValue.text = curMusVolume.ToString();


        curSFXvolume = Mathf.Round(sfxVolumeSlider.value * 100);
        txt_sfx_volume.text = curSFXvolume.ToString();

    }

    internal static float getMusVolume()
    {
        return curMusVolume;
    }


    internal static float getSFXVolume()
    {
        return curSFXvolume;
    }
}
