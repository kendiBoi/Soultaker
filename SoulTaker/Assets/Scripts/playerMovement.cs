using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jump = 5f;
    public bool isGrounded = false;
    public bool isJumping = false;
    public Animator animator;
    float horizontalMove = 0f;
    float horizontal = 0f;
    
    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        
        
    }

   

    void Move()
    {
            horizontal = Input.GetAxis("Horizontal");
            Vector3 distance = new Vector3(horizontal, 0f, 0f);
            horizontalMove= horizontal * Time.deltaTime * speed;

            transform.position += distance * Time.deltaTime * speed;
            FlipSprite();
            
            animator.SetFloat("speed",Mathf.Abs(horizontalMove));
    }

    private void FlipSprite()
    {
        Vector3 spriteScale = transform.localScale;
        if (horizontal < 0)
        {
            spriteScale.x = -1;
        }
        if (horizontal > 0)
        {
            spriteScale.x = 1;
        }
        transform.localScale = spriteScale;
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded == true)
        {
            SoundManager.PlaySound("Jump");
            isJumping = true;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jump), ForceMode2D.Impulse);
            animator.SetBool("isJumping", isJumping);
        }
        else if(isJumping == true)
        {
            isJumping = false;
            animator.SetBool("isJumping", isJumping);
        }
    }

   
}
