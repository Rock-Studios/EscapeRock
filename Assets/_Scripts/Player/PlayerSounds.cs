using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip AudioClipPowerUp;

    public AudioClip AudioClipMonster;

    public AudioClip AudioClipDie;

    private void Awake()
    {
      audioSource = GetComponent<AudioSource>();
    }

    public void PlayerCollectPowerUp()
    {
        PlayClip(AudioClipPowerUp);
    }   

    public void PlayerDie()
    {
        PlayClip(AudioClipDie);
    }

    public void PlayerHitMonster()
    {
        PlayClip(AudioClipMonster);
    }

    private void PlayClip(AudioClip clip)
    {
        audioSource.Stop();
        audioSource.clip = clip;  
        audioSource.Play();
    }
}
