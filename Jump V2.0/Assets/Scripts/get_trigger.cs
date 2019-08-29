using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class get_trigger : MonoBehaviour
{
    public static bool trigger;
    private void Start()
    {
        trigger = false;
    }
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        trigger = true;
        
    }
}
