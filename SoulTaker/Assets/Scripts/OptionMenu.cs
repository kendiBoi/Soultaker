using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class OptionMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void SetVolume(float Volume)
    {
        audioMixer.SetFloat("Volume", Volume);
    }
   
    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
