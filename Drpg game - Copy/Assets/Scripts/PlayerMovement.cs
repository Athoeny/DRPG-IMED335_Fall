using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody2D rb;
    public Animator animator;

    private Vector2 moveDirection;

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }


    void FixedUpdate()
    {
        // Physics Calculations
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", moveX);
        animator.SetFloat("Vertical", moveY);
        animator.SetFloat("Speed", moveDirection.sqrMagnitude);

        moveDirection = new Vector2(moveX, moveY).normalized;
    }
    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
