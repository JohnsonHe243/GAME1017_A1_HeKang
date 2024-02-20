using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainController : MonoBehaviour
{
    public static MainController instance;

    private void Awake()
    {
        // Instanace creation and enforcement of only one objects.
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);
            Initialize();

        }
        else // If instance already exists and points to an instance of MainController.
        {
            Debug.Log("Goodbye cruel world!");
            Destroy(gameObject); // Destroy the new instance, so only the original remains.
        }
    }

    void Start()
    {  
        //SoundManager.Instance.AddSound("Boom", Resources.Load<AudioClip>("boom"), SoundManager.SoundType.SOUND_SFX);
        //SoundManager.Instance.AddSound("Death", Resources.Load<AudioClip>("death"), SoundManager.SoundType.SOUND_SFX);
        //SoundManager.Instance.AddSound("Jump", Resources.Load<AudioClip>("jump"), SoundManager.SoundType.SOUND_SFX);
        //SoundManager.Instance.AddSound("Laser", Resources.Load<AudioClip>("laser"), SoundManager.SoundType.SOUND_SFX);
        //SoundManager.Instance.AddSound("MASK", Resources.Load<AudioClip>("MASK"), SoundManager.SoundType.SOUND_MUSIC);
        //SoundManager.Instance.AddSound("TCats", Resources.Load<AudioClip>("Thundercats"), SoundManager.SoundType.SOUND_MUSIC);
        //SoundManager.Instance.AddSound("Turtles", Resources.Load<AudioClip>("Turtles"), SoundManager.SoundType.SOUND_MUSIC);

        // ADD DONT DESTROY ON LOAD!!!
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
