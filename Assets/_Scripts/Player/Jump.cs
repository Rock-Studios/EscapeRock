using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 10f; // Adjust the jump force as needed
    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check for ground detection, you can adjust this based on your game's setup
        // You might want to use raycasting or colliders to detect if the player is grounded.
        // Here, we are using a simple example for demonstration purposes.
        isGrounded = Physics.Raycast(transform.position, Vector3.down, 1.1f);

        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            JumpPlayer();
        }
    }

    void JumpPlayer()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}


