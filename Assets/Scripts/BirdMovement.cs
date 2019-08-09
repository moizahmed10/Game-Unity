using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public float moveSpeed = 0.25f;
    float movementLimit = 4.12f;
    int direction = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.x) >= Mathf.Abs(movementLimit))
            direction *= -1;
        transform.position += new Vector3(moveSpeed * direction, 0, 0);
    }
}