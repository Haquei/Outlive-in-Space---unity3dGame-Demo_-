using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class move : MonoBehaviour
{

    public int speed;
    public int rotate;
    int GameScore = 0;
    public int winscore = 80;
    public Text Score;
    public Transform sparkel;

    [SerializeField]
    private life_Timer life_Timer_object;
    bool canplay = true;

    public GameObject score_Hide;
    public GameObject timer_Hide;
    public GameObject Gameover;
    public GameObject PlayAgain;
    public GameObject MainMenu;
    public GameObject QuitGame;
    public GameObject win;

    Rigidbody m_Rigidbody;



    void Start()
    {
        Score.text = "Score: 0";
        sparkel.GetComponent<ParticleSystem>().enableEmission = false;
        score_Hide.SetActive(true);
        timer_Hide.SetActive(true);
        Gameover.SetActive(false);
        PlayAgain.SetActive(false);
        MainMenu.SetActive(false);
        QuitGame.SetActive(false);
        win.SetActive(false);
        m_Rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (canplay) 
        {
            if (life_Timer_object.timer == 0 || transform.position.y <= -8 )
            {
                canplay = false;
                score_Hide.SetActive(false);
                timer_Hide.SetActive(false);
                Gameover.SetActive(true);
                PlayAgain.SetActive(true);
                MainMenu.SetActive(true);
                QuitGame.SetActive(true);
                m_Rigidbody.constraints = RigidbodyConstraints.FreezePositionY;
            }
            if(GameScore == winscore)
            {
                canplay = false;
                score_Hide.SetActive(false);
                timer_Hide.SetActive(false);
                win.SetActive(true);
                PlayAgain.SetActive(true);
                MainMenu.SetActive(true);
                QuitGame.SetActive(true);

            }

            else
            {
                playermovement();
            }

        }

      
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "crystal")
        {
            Debug.Log("working");
            GameScore += 1;
            Destroy(col.gameObject);
            sparkel.GetComponent<ParticleSystem>().enableEmission = true;
           
            Score.text = "Score:" + GameScore.ToString();
        }

        if(col.gameObject.tag == "big_crystal")
        {
            Debug.Log("touching");
            life_Timer_object.timer += 15;
            Destroy(col.gameObject);
        }

    }

    void playermovement()
    {
        float X = Input.GetAxis("Horizontal") * Time.deltaTime * rotate;
        float Z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(0, 0, Z);
        transform.Rotate(0, X, 0);
    }

   public void playAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void quitGame()
    {
        Application.Quit();
        Debug.Log("game quited");
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene("menu_");
    }



}
