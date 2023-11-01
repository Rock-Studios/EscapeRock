using UnityEngine;

public class RollingBoulder : MonoBehaviour
{
    public float speed = 30f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Set the boulder's initial velocity
        rb.velocity = new Vector2(+speed, 0); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(playerHealth.currentHealth);
        }
    }
}
