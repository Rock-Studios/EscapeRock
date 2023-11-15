using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;   

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount; 


        if (currentHealth <= 0)
        {
            Die(); 
        }
    }

    void Die()
    {
        Debug.Log("Player died!");  
        Destroy(gameObject);        
    }
}
