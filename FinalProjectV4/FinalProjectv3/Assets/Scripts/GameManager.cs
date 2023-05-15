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
    public GameObject[] hazardSpawnArray;  

    public GameObject[] hazardSpawnArray2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnHazard1", 0, 2);
        InvokeRepeating("spawnHazard2", 3, 4);
        
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
    else 
    if (playerDeath.gameObject.CompareTag("Destroy"))
    {
            Destroy(gameObject);
    }
    else 
    if (playerDeath.gameObject.CompareTag("Hazard2"))
    {
         player.transform.position = startPoint.transform.position;
    }
}

private void spawnHazard1()
{
    for(int i=0;i<hazardSpawnArray.Length;i++)
    {
        Instantiate(hazardPrefab,hazardSpawnArray[i].transform.position, Quaternion.identity);
    }
}

private void spawnHazard2()
{
    for(int i=0;i<hazardSpawnArray2.Length;i++)
    {
        Instantiate(hazardPrefab,hazardSpawnArray2[i].transform.position, Quaternion.identity);
    }
}

}

