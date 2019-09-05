using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipmoveTWO : MonoBehaviour
{
     public float moveSpeed = 5f;
    private Rigidbody myRigidbody;
    private Vector3 inputVector; //gets input from update and sends it to physics
    
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>(); //assign RB ref 
    }

    // Update is called once per frame
    void Update()
    {
        //NEW player movement
        //float vertical = Input.GetKeyDown("Vertical"); //corresponds to W/S or Up/Down
       // float horizontal = Input.GetKeyDown("Horizontal"); // A/D or Left/Right
		
       // inputVector = transform.up * vertical * moveSpeed; //forward/back direction
      // inputVector += transform.right * horizontal * moveSpeed; //left/right direction
        //Debug.Log("vertical" + vertical);
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            myRigidbody.velocity = new Vector3(0, 5, 0);
        }
       if (Input.GetKey(KeyCode.DownArrow))
        {
            myRigidbody.velocity = new Vector3(0, -5, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.velocity = new Vector3(5, 0, 0);
       }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.velocity = new Vector3(-5, 0, 0);
        }
        //horizontal input (A/D, Left/Right)
       // float horizontalInput = Input.GetAxis("Horizontal");
        //vertical input (W/S, Up/Down)
             // float verticalInput = Input.GetAxis("Vertical");
        
        //use horizontal input for turning only
       // transform.Rotate(0f,0f, horizontalInput * Time.deltaTime * 90f);
        
        //put the input data in the "inputVector"
            //inputVector = new Vector3(0f, verticalInput, 0f);
        
        //is the player moving faster than 5? normalize
        if (inputVector.magnitude > 1f)
        {
            inputVector = Vector3.Normalize(inputVector);
        }
        
        
    }
    
    //fixed update for physics
    void FixedUpdate()
    {
        myRigidbody.AddForce(inputVector * 10f);
        Debug.Log("input vector" + inputVector);
    }


}