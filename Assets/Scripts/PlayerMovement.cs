using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform player;
    public float speed = 2;

    Rigidbody2D rbody2D;

    public float jumpForce = 6.5f;
    public bool jump;

    bool istochingFront = false;
    bool wallSliding;

    public float wallSlidingSpeed = 0.75f;

    bool istouchingDerecha;
    bool istouchingIzquierda;

    public bool movement = true;

    public static bool rightOfLeft = true;

    void Start()
    {
        
        rbody2D = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire1")) && Detection.isGrounded)
        {
            rbody2D.velocity = new Vector2(rbody2D.velocity.x, jumpForce);
        }
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire1")) && !Detection.isGrounded && Detection.isWall == true)
        {
            rbody2D.velocity = new Vector2(rbody2D.velocity.x, jumpForce);
            if (movement)
            {
                movement = false;
            }
            else
            {
                movement = true;
            }
        }
        
    }

    private void FixedUpdate()
    {
        if (movement)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            rbody2D.velocity = new Vector2(speed, rbody2D.velocity.y);
            rightOfLeft = true;
        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            rbody2D.velocity = new Vector2(-speed, rbody2D.velocity.y);
            rightOfLeft = false;
        }

    

        if (istochingFront == true && Detection.isGrounded == false)
        {
            wallSliding = true;
        }
        else
        {
            wallSliding = false;
        }
        if (wallSliding)
        {
            rbody2D.velocity = new Vector2(rbody2D.velocity.x, Mathf.Clamp(rbody2D.velocity.y, -wallSlidingSpeed, float.MaxValue));

        }

    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Walls") && !Detection.isGrounded)
        {
            istochingFront = true;
            istouchingIzquierda = true;
            istouchingDerecha = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        istochingFront = false;
        istouchingDerecha = false;
        istouchingIzquierda = false;
    }

}
