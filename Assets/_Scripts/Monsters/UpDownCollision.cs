using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownCollision : MonoBehaviour
{
    public bool direction = true;
    public float speed = 5.0f;

    void Update()
    {
        float verticalMovement = speed * Time.deltaTime;

        if (direction)
        {
            Vector3 move = new Vector3(0, verticalMovement, 0);
            transform.position += move;
        }
        else
        {
            Vector3 move = new Vector3(0, -verticalMovement, 0);
            transform.position += move;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Collision with: " + collision.gameObject.tag);

        if (collision.gameObject.CompareTag("Wall"))
        {
            direction = !direction;
        }
    }
}

