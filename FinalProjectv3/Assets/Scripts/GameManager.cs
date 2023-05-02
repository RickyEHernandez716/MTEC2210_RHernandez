using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


public class GameManager : MonoBehaviour
{
    //Declaring variables 

    //Variable 'target' used for Main Camera


    public GameObject startPoint; 
    public GameObject player;
    public GameObject hazardPrefab;
    public GameObject[] hazardArray;
    public GameObject camTarget;
    public GameObject cam;
    

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("spawnHazard1", 0, 1);
        //InvokeRepeating("spawnHazard2", 1, 1);
        
    }

    // Update is called once per frame
    void Update()
    {
        //Uses transform.position to declare new vector 3 where position is assigned to variable 'target' on each axis except z.
        cam.transform.position = new Vector3(cam.transform.position.x, camTarget.transform.position.y, -10);
    }

private void OnCollisionEnter2D(Collision2D playerDeath)
{
    if (playerDeath.gameObject.CompareTag("Player"))
    {
        //player.transform.position = startPoint.transform.position;
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

