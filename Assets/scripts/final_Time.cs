using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class final_Time : MonoBehaviour
{
    public float timer2 = 0f;
    public Text timerText2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        timer2 += Time.deltaTime;

        displayFinalTime(timer2);
    }

    void displayFinalTime(float timetoDisplay)
    {
        if (timetoDisplay < 0)
        {
            timetoDisplay = 0;

        }

        float minutes = Mathf.FloorToInt(timetoDisplay / 60);
        float seconds = Mathf.FloorToInt(timetoDisplay % 60);

        timerText2.text = string.Format("Total Time: {0:00}:{1:00}", minutes, seconds);
    }
}
