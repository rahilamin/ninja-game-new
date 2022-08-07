using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paralex : MonoBehaviour
{
    private float lenght,startPos;
    public GameObject cam;
    public float paralexEffect;

       
    void Start()
    {
        startPos = transform.position.x;
       lenght = GetComponent<SpriteRenderer>().localBounds.size.x;
       
    }



    void FixedUpdate()
    {

        

        float temp = (cam.transform.position.x * (1 - paralexEffect));
        float dist = (cam.transform.position.x * paralexEffect);

        transform.position = new Vector3(startPos + dist, transform.position.y, transform.position.z);

        if (temp > startPos +lenght)
        {
          
            startPos += lenght;
        } 
        else if (temp < startPos - lenght)
        {
             startPos -= lenght;
        }

    }
}
