using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BallSpanwer : MonoBehaviour
{


    public Text scoreText;
   
    private int currentScore = 0;
    public int hoopsRequired = 3;
    //public GameObject hoop;
    

    

    void Start()
    {
        //find gameobjects with tag ball
        // if list size == 2 
        // then remove one of them
    }


    void Update()
    {
        //GameObject[] balls = GameObject.FindGameObjectsWithTag("ball");

        // if(balls.Length == 2)
        //   {
        //  GameObject ballToRemove = balls[0];
        // Destroy(ballToRemove);
        //  }

         void OnTriggerEnter2D(Collider2D collision)
        {


            if (collision.CompareTag("Score"))
            {

                currentScore++;
                scoreText.text = "Score: " + currentScore;

            }

            GameObject.Find("WorkingBall").GetComponent<HoopManger2>().highscoreUpdate();
        }
    }
}

