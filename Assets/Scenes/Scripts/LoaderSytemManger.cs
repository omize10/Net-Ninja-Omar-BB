using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderSytemManger : MonoBehaviour
{
    public HoopManger2 HM2;

    void Start()
    {
        HM2 = GameObject.Find("WorkingBall").GetComponent<HoopManger2>();
    }


    void Update()
    {
        
    }

    void LevelTen()
    {
        int currentHighScore = PlayerPrefs.GetInt("HighScore", 0);
        if (currentHighScore >= 11 && currentHighScore < 16)
        {
            SceneManager.LoadScene("Level10");
        }
    }

    void LevelFifteen()
    {

        int currentHighScore = PlayerPrefs.GetInt("HighScore", 0);
        if (currentHighScore >= 16 && currentHighScore < 21)
        {
            SceneManager.LoadScene("Level15");
        }

    }
        void LevelTwenty()
        {
            int currentHighScore = PlayerPrefs.GetInt("HighScore", 0);
            if (currentHighScore >= 21 && currentHighScore < 25)
            {
                SceneManager.LoadScene("Level20");
            }
        }

    }









