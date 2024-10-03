using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioMenu : MonoBehaviour
{
    public AudioMixer Mixer;
    public Slider Master;
    public Slider Music;
    public Slider SFX;
    void Start()
    {
        SetMusicVolumeMaster();
        SetMusicVolumeMusic();
        SetMusicVolumeSFX();
    }
    public void SetMusicVolumeMaster()
    {
        float volume = Master.value;
        Mixer.SetFloat("Master", Mathf.Log10(volume) * 20);
    }
    public void SetMusicVolumeMusic()
    {
        float volume = Master.value;
        Mixer.SetFloat("Music", Mathf.Log10(volume) * 20);
    }
    public void SetMusicVolumeSFX()
    {
        float volume = Master.value;
        Mixer.SetFloat("SFX", Mathf.Log10(volume) * 20);
    }
    void Update()
    {
        
    }
}
