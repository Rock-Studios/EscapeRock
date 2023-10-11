using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownMove : MonoBehaviour
{
    public float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        Vector3 move;
        move = new Vector3(0, speed * Time.deltaTime, 0);
        transform.position -= move;
    }
}
