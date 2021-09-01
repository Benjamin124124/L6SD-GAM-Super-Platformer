using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    public float speed;
    public float jump;
    float moveVelocity;

    bool grounded = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            if(grounded)
            {
                GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jump);
            }
        }

        moveVelocity = 0;

        if(Input.GetKey (KeyCode.A))
        {
            moveVelocity = -speed;


        }
        if(Input.GetKey (KeyCode.D))
        {
            moveVelocity = speed;
            
        }

        GetComponent<Rigidbody2D> ().velocity = new Vector2 (moveVelocity, GetComponent<Rigidbody2D> ().velocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = false;
        }
    }
}
