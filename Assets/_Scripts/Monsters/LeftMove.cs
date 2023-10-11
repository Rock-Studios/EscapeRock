using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    public float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        Vector3 move;
        move = new Vector3(speed * Time.deltaTime, 0, 0);
        transform.position -= move;
    }
}
