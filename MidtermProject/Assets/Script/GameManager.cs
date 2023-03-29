using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour

{
    public Transform leftPoint;
    public Transform rightPoint;
    public GameObject[] prefabs;
    //public TextMeshProUGUI coinText; 
    //public int coinNum = -1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObjects", 2, 1);
    }

    // Update is called once per frame
    void Update()
    {
        //coinText.text = "RUPEES: " + coinNum.ToString();
    }

    public void spawnObjects()
    {
        
        float xPos = Random.Range(leftPoint.position.x, rightPoint.position.x);
        float yPos = leftPoint.position.y;
        Vector3 RandomCoinPosition = new Vector3(xPos, yPos,0);
        int indexPrefab = Random.Range(0, 3);
        Instantiate(prefabs[indexPrefab], RandomCoinPosition, Quaternion.identity);
        
    }

   /* private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Rupee"))
        {
            Destroy(collision.gameObject);
        }
        else 
        if(collision.gameObject.CompareTag("Hazard"))
        {
            Destroy(collision.gameObject);
            coinNum++;
        }
        else 
        if(collision.gameObject.CompareTag("Triforce"))
        {
            Destroy(collision.gameObject);
            print("The Theme Has Been Changed");
        }
    }*/
}

