using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 10f;
    public float forwardSpeed = 5f;

    private Rigidbody2D rb2D; // Change this line
    private bool isGrounded;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>(); // And this line
    }

    void Update()
    {
        // Check for ground detection
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 1.1f);

        // Jump logic
        if (isGrounded && Input.GetKeyDown(KeyCode.W))
        {
            JumpPlayer();
        }

        // Always move forward
        MoveForward();
    }

    void MoveForward()
    {
        rb2D.velocity = new Vector2(forwardSpeed, rb2D.velocity.y);
    }

    void JumpPlayer()
    {
        rb2D.velocity = new Vector2(rb2D.velocity.x, jumpForce);
    }
}
