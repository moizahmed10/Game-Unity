using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxtime = 25f;
    public float timer = 0;
    public float min = 0.1f, max = 0.6f;
    public GameObject Ring;
    public GameObject Pipeup;
   
    public float gap = 0;
    int check;

    // Start is called before the first frame update
    void Start()
    {
        check = (int)(Random.Range(min, max) * 10);

        GameObject newring = Instantiate(Ring);
        newring.transform.position = new Vector2(gap, check);
  
        GameObject newpipe1 = Instantiate(Pipeup);
        newring.transform.position = new Vector2(gap - 4, 0);
        gap += 10;
       
    }

    // Update is called once per frame
    void Update()
    {
       
        if (timer > maxtime)
        {
            check = (int)(Random.Range(min, max) * 10);
            GameObject newring = Instantiate(Ring);
            newring.transform.position = new Vector2(gap, check);
            

            GameObject newpipe1 = Instantiate(Pipeup);
            newpipe1.transform.position = new Vector2(gap + 4, 0);
            gap += 10;
            timer = 0;
        }
        
        
           
        
       
        timer += 0.1f;
    }
}

