using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;

    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
        Time.timeScale = 0;
    }

    void Update()
    {
          if (Input.GetMouseButtonDown(0))
                {
                  Time.timeScale = 1;
                    rb.velocity = Vector2.up * speed ; 
                }
        
    }
}
