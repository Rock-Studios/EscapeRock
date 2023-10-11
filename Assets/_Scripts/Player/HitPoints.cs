using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPoints : MonoBehaviour
{
    public int hitpoints = 3;
    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Monster"))
        {
            hitpoints--;
            Debug.Log("Player lost hitpoint. Remaining hitpoints: " + hitpoints);

            if (hitpoints < 0)
            {
                hitpoints = 0; // Ensure hitpoints don't go below 0.
            }
  
            if (hitpoints <= 0)
            {
                // Game over logic goes here, e.g., restart the game or show a game over screen.
                Debug.Log("Game Over");
                // You can add your game over logic here.
            }
        }

        if (collision.gameObject.CompareTag("Power Up"))
        {
            hitpoints++;
            Debug.Log("Player Gains Hitpoints: " + hitpoints);
        }
    }
}



