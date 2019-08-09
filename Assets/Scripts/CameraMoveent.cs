using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveent : MonoBehaviour
{
    public Rigidbody2D player;
    float initialDifference;
    float currentDifference;


    // Start is called before the first frame update
    void Start()
    {
        initialDifference = player.transform.position.y - transform.position.y + 2;
    }

    // Update is called once per frame
    void Update()
    {
        currentDifference = player.transform.position.y - transform.position.y;
        if (currentDifference > initialDifference)
        {
            transform.position = new Vector3(0, player.transform.position.y - initialDifference, -10);
        }

    }
}