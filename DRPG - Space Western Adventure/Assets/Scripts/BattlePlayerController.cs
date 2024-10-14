using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]

public class PlayerController : MonoBehaviour
{
    // Move player in 2D space
    public float maxSpeed = 3.4f;
    public float jumpHeight = 6.5f;
    public float gravityScale = 0.8f;

    public Animator animator;

    public bool facingRight = false;
    float moveDirection = 0;
    public bool isGrounded = false;
    Vector3 cameraPos;
    Rigidbody2D r2d;
    CapsuleCollider2D mainCollider;
    Transform t;

    // Use this for initialization
    void Start()
    {
        t = transform;
        r2d = GetComponent<Rigidbody2D>();
        mainCollider = GetComponent<CapsuleCollider2D>();
        r2d.freezeRotation = true;
        r2d.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        r2d.gravityScale = gravityScale;
        facingRight = t.localScale.x > 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Movement controls
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) && (isGrounded || Mathf.Abs(r2d.velocity.x) > 0.01f))
        {
            if ((Input.GetKey(KeyCode.A)))
            {
                moveDirection = -1;
                r2d.velocity = new Vector2(-maxSpeed, r2d.velocity.y);

            }
            else if ((Input.GetKey(KeyCode.D)))
            {
                moveDirection = 1;
                r2d.velocity = new Vector2(maxSpeed, r2d.velocity.y);
            }
        }
        else
        {
            if (isGrounded || r2d.velocity.magnitude < 0.01f)
            {
                moveDirection = 0;
            }
        }

        // Change facing direction
        if (moveDirection != 0)
        {
            if (moveDirection > 0 && !facingRight)
            {
                Debug.Log("flip");
                Flip();
                
            }
            else if (moveDirection < 0 && facingRight)
            {
                Debug.Log("flip 2");
                Flip();
            }
        }

        // Jumping
        if (Input.GetKeyDown(KeyCode.W) && isGrounded)
        {
            r2d.gravityScale = 0.8f;
            isGrounded = false;
            animator.SetBool("isJumping", true);
            r2d.velocity = new Vector2(r2d.velocity.x, jumpHeight);
            Debug.Log("The Sky");
        }

        //Stomp
        if (Input.GetKeyDown(KeyCode.S))
        {
            r2d.velocity = Vector3.zero;
            r2d.gravityScale = 3f;
            Debug.Log("gravity mode is on whoag");
            animator.SetFloat("yVelocity", -1);
        }
    }

    void FixedUpdate()
    {
        animator.SetFloat("xVelocity", Math.Abs(r2d.velocity.x));
        animator.SetFloat("yVelocity", r2d.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        if ((animator.GetFloat("yVelocity") < 0))
        {
            animator.SetBool("isJumping", false);
            Debug.Log("the floor");
        }
        
    }

    void Flip()
    {
        facingRight = !facingRight;
        t.Rotate(0f, 180f, 0f);
    }
}
