using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    [Header("Music")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioClip quizMusic;
    [SerializeField] AudioClip endMusic;

    [Header("SFX")]
    [SerializeField] AudioSource sfxSource;
    [SerializeField] AudioClip correctSFX;
    [SerializeField] AudioClip wrongSFX;

    void Awake()
    {
        Instance = this;
    }

    public void PlayQuizMusic()
    {
        musicSource.clip = quizMusic;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PlayEndMusic()
    {
        musicSource.clip = endMusic;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PauseMusic()
    {
        musicSource.Pause();
    }

    public void ResumeMusic()
    {
        musicSource.UnPause();
    }

    public void PlayCorrectSFX()
    {
        sfxSource.PlayOneShot(correctSFX);
    }

    public void PlayWrongSFX()
    {
        sfxSource.PlayOneShot(wrongSFX);
    }
}
