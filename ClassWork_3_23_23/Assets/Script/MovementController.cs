using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public bool Player1;
    public KeyCode pLeft;
    public KeyCode pRight;
    public KeyCode pUp;
    public float speed;
    public float intensity;
    public Rigidbody2D rb;
    private float xMove;
    private float yMove;
    private bool jumpFlag; 
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
            
        }
        else
        {
            rb.AddForce(new Vector2(xMove,0)* intensity);
            rb.AddForce(new Vector2(0, yMove) * intensity);
           
        }

        if (jumpFlag) {
            rb.velocity = new Vector2(rb.velocity.x, 10);
            jumpFlag = false;
        }
    }
}