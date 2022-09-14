using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{
    private Rigidbody2D rb2D;

    private float moveSpeed;
     private float jumpForce;
     private bool InAir2;
     private float movehorizontal2;
     private float movevertical2;
    void Start()
    {

        rb2D = gameObject.GetComponent<Rigidbody2D>();
        moveSpeed = 3f;
        jumpForce = 60f;
        InAir2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        movehorizontal2 = Input.GetAxisRaw("HorizontalPog");
        movevertical2 = Input.GetAxisRaw("VerticalPog");


    }

    void FixedUpdate ()
    {
        if(movehorizontal2 > 0.1f || movehorizontal2 < -0.1f)
        {
        rb2D.AddForce(new Vector2(movehorizontal2*moveSpeed,0f), ForceMode2D.Impulse);
        }
        if(!InAir2 && movevertical2 > 0.1f)
        {
           //float extraheighttext= .01f;
        rb2D.AddForce(new Vector2 (0f, movevertical2 * jumpForce), ForceMode2D.Impulse);

        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
    if(collision.gameObject.tag == "Ground ")
    {
        InAir2= false;
    }

    }

    void OnTriggerExit2D(Collider2D collision)
    {
    if(collision.gameObject.tag == "Ground ")
    {
        InAir2= true;
    }

    }
}

