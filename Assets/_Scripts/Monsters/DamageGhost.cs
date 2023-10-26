using UnityEngine;

public class DamageGhost : MonoBehaviour
{
    public int damageAmount = 1; // Represents half a heart

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Check if the colliding object has the "Player" tag
        if (collision.gameObject.CompareTag("Player"))
        {
            /*Player player = collision.gameObject.GetComponent<Player>();

            if (player != null)
            {
                player.TakeDamage(damageAmount);
                Debug.Log("Player touched the ghost and lost health!");
            }*/
        }
    }
}

