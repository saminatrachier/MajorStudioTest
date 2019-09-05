using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipRaycast : MonoBehaviour
{
    //Purpose: Have the ship shoot out a raycast to detect an asteroid
    //if the ray comes back positive, then the ship despawns and respawns at the beginning
    //if the ray comes back negative then nothing happens
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //define ray variable; senses object from origin?
        Ray shipRay = new Ray(transform.position, transform.forward);
        
        //declare ray cast distance
        float maxRayDistance = 1.5f;
        
        //visualize raycast
        Debug.DrawRay(shipRay.origin, shipRay.direction * maxRayDistance, Color.magenta);
        
        //shoot the raycast
        if (Physics.Raycast(shipRay, maxRayDistance))
        {
            Debug.Log("Ship sensed something!");
        }
    }
}
