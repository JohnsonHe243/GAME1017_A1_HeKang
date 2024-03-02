using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        SoundManager.Instance.AddSound("Canon", Resources.Load<AudioClip>("canon"), SoundManager.SoundType.SOUND_SFX);
        SoundManager.Instance.AddSound("Destruction", Resources.Load<AudioClip>("destruction"), SoundManager.SoundType.SOUND_SFX);
        SoundManager.Instance.AddSound("EnemeyShoot", Resources.Load<AudioClip>("enemyshoot"), SoundManager.SoundType.SOUND_SFX);
        SoundManager.Instance.AddSound("Explosion", Resources.Load<AudioClip>("explosion"), SoundManager.SoundType.SOUND_SFX);
        SoundManager.Instance.AddSound("Missile", Resources.Load<AudioClip>("missile"), SoundManager.SoundType.SOUND_SFX);
        SoundManager.Instance.AddSound("GameOver", Resources.Load<AudioClip>("gameover"), SoundManager.SoundType.SOUND_MUSIC);
        SoundManager.Instance.AddSound("Title", Resources.Load<AudioClip>("title"), SoundManager.SoundType.SOUND_MUSIC);
        SoundManager.Instance.AddSound("Game", Resources.Load<AudioClip>("game"), SoundManager.SoundType.SOUND_MUSIC);
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
