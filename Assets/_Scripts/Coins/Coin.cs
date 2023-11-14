using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioClip coinSoundClip; // Assign this in the Inspector

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Increment the score
            HighScore.instance.AddScore(1);

            // Play the coin sound at the position of the coin
            AudioSource.PlayClipAtPoint(coinSoundClip, transform.position);

            // Destroy the coin
            Destroy(gameObject);
        }
    }
}
