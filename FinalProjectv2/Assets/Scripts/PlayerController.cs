using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool Player1;
    public KeyCode pLeft;
    public KeyCode pRight;
    public KeyCode pUp;
    public float speed;
    public float intensity;
    public float jump; 
    public Rigidbody2D rb;
    private float xMove;
    private float yMove;
    private bool jumpFlag; 
    private bool isJumping; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(pLeft))
        {

            xMove = -1;
        }
        else if (Input.GetKey(pRight))
        {

            xMove = 1;
        }
        else if (Input.GetKey(pUp))
        {
            yMove = 1;
        }
        else 
        {
            xMove= 0;
            yMove= 0;
        }

        if (Input.GetKeyDown(pUp)) 
        { 
        jumpFlag = true;
        }

    }

    private void FixedUpdate()
    {
        if (Player1)
        {
            rb.velocity = new Vector2(xMove * speed * 10 * Time.fixedDeltaTime, rb.velocity.y);

            if (jumpFlag == true && isJumping == false)
            {
                rb.velocity = new Vector2(rb.velocity.x, jump);
                jumpFlag = false;
            }

        }
        else
        {
            rb.AddForce(new Vector2(xMove,0)* intensity);
            rb.AddForce(new Vector2(0, yMove) * intensity);
           
        }


        if (jumpFlag == true && isJumping == false) 
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
            jumpFlag = false;
        }

    }
    
    /*Checks to see if player is jumping by cpmparing tags to see if they are interacting with each other to let game know if
      player is jumping or on the ground/box to jump again*/
    void OnCollisionEnter2D(Collision2D other) {
            
            if(other.gameObject.CompareTag("Ground"))
            {
                isJumping = false;
            }

            if(other.gameObject.CompareTag("Box"))
            {
                isJumping = false;
            }
        }

    void OnCollisionExit2D(Collision2D other) {
            
            if(other.gameObject.CompareTag("Ground"))
            {
                isJumping = true;
            }

            if(other.gameObject.CompareTag("Box"))
            {
                isJumping = true;
            }
        
        }
}
