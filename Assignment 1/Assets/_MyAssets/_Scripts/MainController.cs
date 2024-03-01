using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainController : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] gameController = GameObject.FindGameObjectsWithTag("MainController");
        if (gameController.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        //SoundManager.Instance.AddSound("", Resources.Load<AudioClip>(""), SoundManager.SoundType.SOUND_SFX);
        SoundManager.Instance.AddSound("TitleMusic", Resources.Load<AudioClip>("titleMusic"), SoundManager.SoundType.SOUND_MUSIC);
    }

    public void PlaySFX(string soundKey)
    {
        SoundManager.Instance.PlaySound(soundKey);
    }

    public void PlayMusic(string soundKey)
    {
        SoundManager.Instance.PlayMusic(soundKey);
    }




}
