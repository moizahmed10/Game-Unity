using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingMovement : MonoBehaviour
{
    public float movespeed = 0.5f;
    public Rigidbody2D rb;

    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        rb.velocity = Vector2.left * movespeed;
    }
}
