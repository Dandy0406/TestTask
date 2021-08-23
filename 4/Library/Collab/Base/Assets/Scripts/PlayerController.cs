using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float index;
    public float speed;
    public int similarity = 5;
    public Vector2 moveVelocity;
    public GameObject inventory;

  
 

    Rigidbody2D rb;
    Animator anim;
    Vector2 moveInput;
    Vector2 lookDirection = new Vector2(1, 0);

    [SerializeField]
    private bool facingRight = true;

    private void Start()
    {
        /*for (int i = 0; i < 4; i++)
        {
            shopPers[i] = GameObject.FindGameObjectWithTag("Pers").GetComponent<ShopPers>();
        }*/
        
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        PlayerPrefs.SetInt("Similarity", similarity);
    }

    private void Update()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;

       
        if (moveVelocity.y!=0f || moveVelocity.x!=0f)
        {
            anim.SetBool("isRunning", true);
        }

        if (moveInput.x==0 && moveInput.y==0f)
        {
            anim.SetBool("isRunning", false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit2D hit = Physics2D.Raycast(rb.position+ Vector2.up * 0.2f, lookDirection, 1.5f, LayerMask.GetMask("NPC"));
            Debug.Log("Hit");
            if(hit.collider != null)
            {
                NonPlayerCharacter character = hit.collider.GetComponent<NonPlayerCharacter>();
                if (character != null)
                {
                    character.DisplayDialog();
                    //shopPers.ShowShop();
                }
          

                



            }
        }

        if (Input.GetKey(KeyCode.Tab))
        {
            inventory.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            inventory.SetActive(false);
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
