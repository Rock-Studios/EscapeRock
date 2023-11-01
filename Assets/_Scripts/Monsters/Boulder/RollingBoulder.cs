using UnityEngine;
using UnityEngine.SceneManagement;
public class RollingBoulder : MonoBehaviour
{
    public float speed = 30f;
    private Rigidbody2D rb;
    private bool isRolling = false; // Add a boolean to control when the boulder starts rolling

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Initialize the boulder's velocity to zero
        rb.velocity = Vector2.zero;
    }

    private void Update()
    {
        // If isRolling is true, set the boulder's velocity
        if (isRolling)
        {
            rb.velocity = new Vector2(+speed, 0);
        }
    }

    public void StartRolling()
    {
        isRolling = true; // This will be called by the button to start the boulder rolling
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);

        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player hit by boulder");
            GameOver.instance.EndGame();
        }
    }
}