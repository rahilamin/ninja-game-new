using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myPlayer : MonoBehaviour
{ public float sideMax = 5f; //Try screen.width
    public float midlimit = 1f;

    public Animator animator;
    public float speed = 0;
    private Touch touch;
    public Rigidbody2D rb ;
  
  void start()
  {
      rb = GetComponent<Rigidbody2D>();
  }
  

    

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector2 (touch.deltaPosition.y*speed/4,
                touch.deltaPosition.y*speed
                    );
            }
          // Debug.Log();

          //  transform.position = Vector2(0,speed*Time.deltaTime);
        }
    }
}
