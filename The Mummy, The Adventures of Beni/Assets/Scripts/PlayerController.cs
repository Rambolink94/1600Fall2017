using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Created this script with lots of help from a Unity player controller tutorial.
    // https://unity3d.com/learn/tutorials/topics/2d-game-creation/2d-character-controllers

    public Rigidbody2D rb;
    public Animator anim;
    public Transform groundCheck;
    public LayerMask learnGround;

    public float speed = 10;
    public float groundRadius = 0.2f;
    public float jumpForce = 700f;

    public bool facingRight = true;
    public bool isGrounded = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, learnGround);
        anim.SetBool("Ground", isGrounded);
        float move = Input.GetAxis("Horizontal");
        anim.SetFloat("Speed", Mathf.Abs(move));
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
        if (move > 0 && !facingRight)
        {
            Flip();
        } else if (move < 0 && facingRight)
        {
            Flip();
        }
    }

    void Update()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetBool("Ground", false);
            rb.AddForce(new Vector2(0, jumpForce));
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}