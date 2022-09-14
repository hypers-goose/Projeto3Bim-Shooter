using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb2D;

    private float moveSpeed;
     private float jumpForce;
     private bool InAir;
     private float movehorizontal;
     private float movevertical;
    void Start()
    {

        rb2D = gameObject.GetComponent<Rigidbody2D>();
        moveSpeed = 3f;
        jumpForce = 60f;
        InAir = false;
    }

    // Update is called once per frame
    void Update()
    {
        movehorizontal = Input.GetAxisRaw("Horizontal");
        movevertical = Input.GetAxisRaw("Vertical");


    }

    void FixedUpdate ()
    {
        if(movehorizontal > 0.1f || movehorizontal < -0.1f)
        {
        rb2D.AddForce(new Vector2(movehorizontal*moveSpeed,0f), ForceMode2D.Impulse);
        }

    if(!InAir && movevertical > 0.1f)
        {
           //float extraheighttext= .01f;
        rb2D.AddForce(new Vector2 (0f, movevertical * jumpForce), ForceMode2D.Impulse);

        }
    }
    
//private bool InAir()
//{
    //Physics2D.Raycast(CapsuleCollider2D.bounds.center, Vector2.down, BoxCollider2D.bounds.extents.y);
//}


    void OnTriggerEnter2D(Collider2D collision)
    {
    if(collision.gameObject.tag == "Ground ")
    {
        InAir= false;
    }

    }

    void OnTriggerExit2D(Collider2D collision)
    {
    if(collision.gameObject.tag == "Ground ")
    {
     InAir= true;
    }

    }}


    

