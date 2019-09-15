using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreplayer1 : MonoBehaviour
{
    //defining variables
    private Text textp1;

    public static int Scorep1;

    // Start is called before the first frame update
    void Start()
    {
        textp1 = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textp1.text = ("" + Scorep1);
    }
}
