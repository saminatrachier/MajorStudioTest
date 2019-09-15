using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipMove : MonoBehaviour
{
    //put this script on the players character

    public float moveSpeed = 5f;
    private Rigidbody myRigidbody;
    private Vector3 inputVector; //gets input from update and sends it to physics
    public float rockspeed = 100f;
    public Vector3 destination; //rock will always move towards destination

    
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
        
        if (Input.GetKey(KeyCode.W))
        {
            myRigidbody.velocity = new Vector3(0, moveSpeed, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            myRigidbody.velocity = new Vector3(0, -moveSpeed, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            myRigidbody.velocity = new Vector3(moveSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            myRigidbody.velocity = new Vector3(-moveSpeed, 0, 0);
        }

        //restart the scene
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(0);
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
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Goal")
        {
            transform.position = new Vector3(-15, -8, 1);
            scoreplayer1.Scorep1++;
        }
        //respawns ship at beginning
        if (other.gameObject.tag == "barrier")
        {
            transform.position = new Vector3(-15,-8,1);
        }

        //knocks the spaceship to the right upon impact
       if (other.gameObject.tag == "rightRock")
      {
          myRigidbody.AddForce(Vector3.right * 10, ForceMode.Impulse);
      }
 
       if (other.gameObject.tag == "leftRock")
        {
           myRigidbody.AddForce(Vector3.left * 10, ForceMode.Impulse);       
    }
    }



}
