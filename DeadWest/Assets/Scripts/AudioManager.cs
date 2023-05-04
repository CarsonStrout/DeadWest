using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource music;
    [SerializeField] private float maxVol;
    private bool fadeOut = false;

    private void Start()
    {
        AudioListener.pause = false;
    }

    private void Update()
    {
        if (!fadeOut)
        {
            if (music.isPlaying)
                music.volume = Mathf.Lerp(music.volume, maxVol, 0.1f * Time.deltaTime);
        }
        else
            music.volume = Mathf.Lerp(music.volume, 0, 2f * Time.deltaTime);
    }

    public void FadeAudio()
    {
        fadeOut = true;
    }
}
