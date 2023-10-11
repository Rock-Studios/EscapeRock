using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    [field: SerializeField]
    public UnityEvent OnCollect { get; set; }

    [field: SerializeField]
    public UnityEvent OnHitEnemy { get; set; }

    [field: SerializeField]
    public UnityEvent OnDie { get; set; }

    public int powerups = 0;
    public int hitpoints = 3;
    public float speed = 1.0f;

    void Update()
    {

        Vector3 move = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            move.y += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            move.x -= speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            move.x += speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S))
        {
            move.y -= speed * Time.deltaTime;
        }

        transform.position = move;
    }

    private void OnCollisonEnter2D(Collision2D collision)
    {
        Debug.Log("I playermoverment.cs og i OnCollisionEnter2D");
        Debug.Log("collision tag:" + collision.gameObject.tag);

        if (collision.gameObject.CompareTag("Monster"))
        {
            Debug.Log("Hit Monster");
            hitpoints--;
            OnHitEnemy?.Invoke();
            if (hitpoints <= 0)
            {
                OnDie?.Invoke();    
                Debug.Log("Game Over");
            }
        }

        if (collision.gameObject.CompareTag("Power Up"))
        {
            powerups++;
            Debug.Log("Power Ups:" + powerups);
        }
    }
}
