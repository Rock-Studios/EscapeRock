using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 40f;
    public float forwardSpeed = 5f;
    public LayerMask groundLayer;
    public float fallMultiplier = 40f;
    public float lowJumpMultiplier = 2f;

    private Rigidbody2D rb2D;
    private bool isGrounded;
    private Animator anim;  // Reference to the Animator


    void Start()
    {
        anim = GetComponent<Animator>();
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        anim.SetBool("isGrounded", isGrounded); 
        anim.SetFloat("VerticalVelocity", rb2D.velocity.y); 

        Debug.DrawRay(transform.position, Vector2.down * 1.5f, Color.red);

        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 1.5f, groundLayer);

        if (isGrounded && Input.GetKeyDown(KeyCode.W))
        {
            JumpPlayer();
        }

        if (rb2D.velocity.y < 0)
        {
            rb2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
        }
        else if (rb2D.velocity.y > 0 && !Input.GetKey(KeyCode.W))
        {
            rb2D.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }

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
