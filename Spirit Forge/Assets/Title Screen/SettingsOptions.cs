using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsOptions : MonoBehaviour{
    
    public AudioMixer audioMixer;

    public void SetVolume (float volume) {
        audioMixer.SetFloat("volume", volume);
        if(volume == -40) {
            audioMixer.SetFloat("volume", -80);
        }
    }

    public void SetFullscreen (bool isFullscreen) {
        Screen.fullScreen = isFullscreen;
    }
}
