using UnityEngine;

public class GhostDamage : MonoBehaviour
{
    public AudioClip ghostSoundClip;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            HighScore.instance.DecreaseScore(1);

            AudioSource.PlayClipAtPoint(ghostSoundClip, transform.position);
        }
    }
}