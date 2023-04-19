using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    //Declaring variables 

    //Variable 'target' used for Main Camera


    public GameObject startPoint; 
    public GameObject player;
   public GameObject hazardPrefab;
    public GameObject[] hazardArray;  

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnHazard1", 0, 1);
        InvokeRepeating("spawnHazard2", 1, 1);
        
    }

    // Update is called once per frame
    void Update()
    {
   
    }

private void OnCollisionEnter2D(Collision2D playerDeath)
{
    if (playerDeath.gameObject.CompareTag("Player"))
    {
        player.transform.position = startPoint.transform.position;
    }
}
/*
private void spawnHazard1()
{
        Instantiate(hazardPrefab[hazardArray], transform.position, Quaternion.identity);
}

private void spawnHazard2()
{
        Instantiate(hazardPrefab[hazardArray], transform.position, Quaternion.identity);
}
*/
}

