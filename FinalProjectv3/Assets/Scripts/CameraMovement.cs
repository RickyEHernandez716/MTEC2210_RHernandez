using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public GameObject target; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //Uses transform.position to declare new vector 3 where position is assigned to variable 'target' on each axis except z.
      transform.position = new Vector3(target.transform.position.x, target.transform.position.y, -10);
    }
}
