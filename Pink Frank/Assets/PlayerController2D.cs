using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{
    Animator animator;
    Rigidbody2D rb2d;
    SpriteRenderer spriteRenderer;
    private bool facing = true;
    private bool jump = true;

    bool isGround;
    [SerializeField]
    Transform groundCheck;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void FixedUpdate() {

        if (Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground")))
        {
            isGround = true;
        }
        else {
            isGround = false;
        }

        if (Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2d.velocity = new Vector2(4, rb2d.velocity.y);
            if(facing == false){
                facing = true;
                transform.Rotate(0f, 180f, 0f);
            }
        }
        else if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb2d.velocity = new Vector2(-4, rb2d.velocity.y);
            if(facing == true){
                facing = false;
                transform.Rotate(0f, 180f, 0f);
            }
        }
        
        

        if (Input.GetKey("space")&&isGround)
        {
            
            rb2d.velocity = new Vector2(rb2d.velocity.x, 8);
        }
    }
}
