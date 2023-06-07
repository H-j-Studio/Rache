using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public AudioSource musicsourse;

    public void SetMusicVolume(float volume)
    {
        musicsourse.volume = volume;
    }
}