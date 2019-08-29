using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovementUp : MonoBehaviour
{
    public float speed = 0.5f;
    public Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {

        this.transform.position += Vector3.left * speed * Time.deltaTime;


        if (get_trigger.trigger == true)
        {
            Time.timeScale = 1;
            rb.velocity = Vector2.up * speed;
        }

    }
}
