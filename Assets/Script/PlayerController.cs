using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public float speed =10; 
     public TextMeshProUGUI coinText; 
     public int coinNum = -1;
     public AudioSource AudioSource;
     public AudioClip rupeeSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float xMove = Input.GetAxisRaw("Horizontal");

        transform.Translate(xMove * speed * Time.deltaTime,0,0);

        coinText.text = "RUPEES: " + coinNum.ToString();
    }
    
     private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Rupee"))
        {
            AudioSource.PlayOneShot(rupeeSound);
            Destroy(collision.gameObject);
            coinNum++;
        }
        else 
        if(collision.gameObject.CompareTag("Hazard"))
        {
            Destroy(gameObject);
            print("You have died!");
        }
        else 
        if(collision.gameObject.CompareTag("Triforce"))
        {
            Destroy(collision.gameObject);
            print("The Theme Has Been Changed");
        }
    }
}