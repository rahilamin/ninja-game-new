using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float playerSpeed;
    
    private Rigidbody2D rb;
    private Vector2 playerDirection;


    //Kieran is a pedo

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Touch touch = Input.GetTouch(0);
        
    }

    // Update is called once per frame
    void Update()
    {
           
                      
            if (Input.)
            {
               rb.velocity = Vector2.up * playerSpeed;


            }
        
        
        
        
    }


  
}
