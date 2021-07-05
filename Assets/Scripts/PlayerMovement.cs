using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;

    public float speed;
    Vector2 movement;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();       
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        Movement();
    }

    void Movement()//移动
    {
        movement.x= Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        float rbx = Input.GetAxisRaw("Horizontal");
        float rby = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(rbx * speed * Time.fixedDeltaTime, rby * speed * Time.fixedDeltaTime);
        

        if (rby != 0|| rbx != 0)//保证Horizontal归0时，保留movment的值来切换idle动画的blend tree
        {
            if (rbx > 0)
            {
                anim.SetFloat("horizontal", 1);
            }
            if (rbx < 0)
            {
                anim.SetFloat("horizontal", -1);
            }
            if (rby > 0)
            {
                anim.SetFloat("vertical", 1);
            }
            if (rby < 0)
            {
                anim.SetFloat("vertical", -1);
            }
        }
        anim.SetFloat("speed", movement.magnitude);

    }


}