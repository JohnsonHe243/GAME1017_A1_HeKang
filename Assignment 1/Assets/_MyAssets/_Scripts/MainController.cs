using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainController : MonoBehaviour
{
    public static MainController instance;

    private void Awake()
    {
        //// Instanace creation and enforcement of only one objects.
        //if (MainController.Instance == null)
        //{
        //    SoundManager.Instance = this;
        //    DontDestroyOnLoad(this);
        //    Instantiate(MainController.instance);

        //}
        //else // If instance already exists and points to an instance of MainController.
        //{
        //    Debug.Log("Goodbye cruel world!");
        //    Destroy(gameObject); // Destroy the new instance, so only the original remains.
        //}
    }

    void Start()
    {  
        //SoundManager.Instance.AddSound("", Resources.Load<AudioClip>(""), SoundManager.SoundType.SOUND_SFX);

        //SoundManager.Instance.AddSound("", Resources.Load<AudioClip>(""), SoundManager.SoundType.SOUND_MUSIC);

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
