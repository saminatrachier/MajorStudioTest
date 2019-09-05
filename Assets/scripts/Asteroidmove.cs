using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroidmove : MonoBehaviour
{

    public float speed = -5f;

    public Vector3 destination; //rock will always move towards destination
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //make the rock always move towards direction
        Vector3 moveDir = destination - transform.position;
        Debug.DrawLine(transform.position, destination, Color.yellow);
        
        //normalizing vector so the rock doesn't teleport
        if(moveDir.magnitude >1f){
            moveDir = moveDir.normalized;
        }
        
        //move the rock
        transform.position += moveDir*speed*Time.deltaTime;
        
        //if the rock reaches its destination, it respawns on the correct side of the screen
        if ((transform.position - destination).magnitude < 2f)
        {
            //moves the rock back to origin
            transform.position = new Vector3(25, transform.position.y, transform.position.z);
        }

    }
}