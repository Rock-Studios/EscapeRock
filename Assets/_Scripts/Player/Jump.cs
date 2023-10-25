using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 10f;
    public float forwardSpeed = 5f;
    public LayerMask groundLayer;
    private Rigidbody2D rb2D;
    private bool isGrounded;

    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Check for ground detection without using LayerMask
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 1.5f, groundLayer);

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
