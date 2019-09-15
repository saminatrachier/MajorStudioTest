using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//usage: get UI components for players when they get a point
public class score : MonoBehaviour
{
    
    //defining variables
    private Text text;

    public static int Score;
    
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = ("" + Score);
    }
}
