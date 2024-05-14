using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSeter : MonoBehaviour
{
    public GameObject[] buttons;
    public HoopManger2 HM2;
    public int amountOfBallsUnlocked = 0;
    GameObject currentButton;

    private void Awake()
    {
        //DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        int hiScore = PlayerPrefs.GetInt("HighScore", 0);
        Debug.Log(hiScore);
        for(int i = 0; i < hiScore; i++)
        {
            buttons[i].SetActive(true);
        }

        HM2 = GameObject.Find("WorkingBall").GetComponent<HoopManger2>();


        //if (HM2.hasHappened)
        //{
        //    amountOfBallsUnlocked++; // Increment unlocked ball count
        //    if (amountOfBallsUnlocked <= buttons.Length)
        //    {
        //        // Activate corresponding button
        //        buttons[amountOfBallsUnlocked - 1].SetActive(true);
        //    }

        //    HM2.hasHappened = false; // Reset flag
       // }
    }

    void Update()
    {
        
    }
}

