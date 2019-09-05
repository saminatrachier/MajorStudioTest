using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    private Image line;

    public float maxTime = 100f;

    private float timeLeft;

    public GameObject timesUpText;
    
    // Start is called before the first frame update
    void Start()
    {
        timesUpText.SetActive(false);
        line = GetComponent<Image>();
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            line.fillAmount = timeLeft / maxTime;
            
        }
        else
        {
            timesUpText.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
