using System.Collections;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSlider : MonoBehaviour
{
    public AudioMixer mixer;

    public void SetVolume(float Volume)
    {
        mixer.SetFloat("MusicVol", Volume);
    }
}
