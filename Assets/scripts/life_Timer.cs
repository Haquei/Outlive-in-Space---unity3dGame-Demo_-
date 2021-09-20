using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class life_Timer : MonoBehaviour
{

    public float timer = 90f;
    public TextMeshPro timerText;
    public Color newColor;
    public AudioSource CoundownClip;
    public AudioClip clip1;

  



    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            timer = 0;
        }

       

        DisplayTime(timer);
      
    }

    void DisplayTime(float timetoDisplay)
    {
        if (timetoDisplay < 0)
        {
            timetoDisplay = 0;
            
        }
        if (timetoDisplay < 11)
        {
            timerText.color = newColor;

           


        }
        float minutes = Mathf.FloorToInt(timetoDisplay / 60);
        float seconds = Mathf.FloorToInt(timetoDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    
}

  
