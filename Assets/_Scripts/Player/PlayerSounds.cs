using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    private AudioSource audioSource;

    public AudioClip AudioClipCoin;
    public AudioClip AudioClipGhost;
    public AudioClip AudioClipDie;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            PlayerCollectCoin();
        }
        else if (collision.gameObject.CompareTag("Ghost"))
        {
            PlayerHitGhost();
        }
    }

    public void PlayerCollectCoin()
    {
        PlayClip(AudioClipCoin);
    }

    public void PlayerDie()
    {
        PlayClip(AudioClipDie);
    }

    public void PlayerHitGhost()
    {
        PlayClip(AudioClipGhost);
    }

    private void PlayClip(AudioClip clip)
    {
        audioSource.Stop();
        audioSource.clip = clip;
        audioSource.Play();
    }
}
