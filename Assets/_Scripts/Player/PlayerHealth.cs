using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100; // Player's max health
    public int currentHealth;   // Player's current health

    private void Start()
    {
        currentHealth = maxHealth; // Initialize the player's health to maximum at the start of the game
    }

    // This method decreases the player's health by the specified amount
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;  // Decrease the current health by the given amount

        // Check if health is less than or equal to 0
        if (currentHealth <= 0)
        {
            Die();  // Call the Die method when health reaches 0 or below
        }
    }

    // Handle player's death (this can be enhanced further as per game's requirement)
    void Die()
    {
        Debug.Log("Player died!");  // Log a message for now
        Destroy(gameObject);        // Destroy the player's game object for now
    }
}
