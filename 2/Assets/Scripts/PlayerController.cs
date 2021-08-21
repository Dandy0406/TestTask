using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float index;
    public float speed;
    public Vector2 moveVelocity;


    private Rigidbody2D rb;
    private Animator anim;
    private Vector2 moveInput;

    [SerializeField]
    private bool facingRight = true;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;

       
        if (moveVelocity.y!=0f || moveVelocity.x!=0f)
        {
            Debug.Log("DA");
            anim.SetBool("isRunning", true);
        }

        if (moveInput.x==0 && moveInput.y==0f)
        {
            Debug.Log("Net");
            anim.SetBool("isRunning", false);
        }


/*
        switch (index)
        {
            case 0:
                Debug.Log("DA");
                break;
            case 1:
                Debug.Log("NET");
                break;
        }
*/

    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);

        if(facingRight == false && moveInput.x > 0)
        {
            Flip();
        } else if (facingRight == true && moveInput.x < 0)
        {
            Flip();
        }
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;
    }
}
