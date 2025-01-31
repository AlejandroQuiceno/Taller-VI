using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundSliders : MonoBehaviour
{
    [SerializeField] private AudioMixer musicMixer, generalMixer;

    public void SetMusicVolume(float sliderValue) {
        musicMixer.SetFloat("MusicMixer", Mathf.Log10(sliderValue) * 20);
    }

    public void SetGeneralVolume(float sliderValue) {
        generalMixer.SetFloat("GeneralMixer", Mathf.Log10(sliderValue) * 20);
    }
}
