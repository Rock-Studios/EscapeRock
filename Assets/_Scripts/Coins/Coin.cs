using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Increment the score
            HighScore.instance.AddScore(1);

            // Destroy the coin
            Destroy(gameObject);
        }
    }
}

