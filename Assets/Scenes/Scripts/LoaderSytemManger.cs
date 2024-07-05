using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoaderSytemManger : MonoBehaviour
{
    public HoopManger2 HM2;
    public GameObject Lten;
    public GameObject LFifteen;
    public GameObject Ltwemty;

    void Start()
    {
        HM2 = GameObject.Find("WorkingBall").GetComponent<HoopManger2>();
    }


    void Update()
    {
        
    }

     public void LevelTen()
    {
        int currentHighScore = PlayerPrefs.GetInt("HighScore", 0);
        if (currentHighScore >= 11 && currentHighScore < 16)
        {
            Lten.SetActive(true);
            SceneManager.LoadScene("Level10");
        }
    }

    public void LevelFifteen()
    {

        int currentHighScore = PlayerPrefs.GetInt("HighScore", 0);
        if (currentHighScore >= 16 && currentHighScore < 21)
        {
            LFifteen.SetActive(true);
            SceneManager.LoadScene("Level15");
        }

    }
        public void LevelTwenty()
        {
            int currentHighScore = PlayerPrefs.GetInt("HighScore", 0);
            if (currentHighScore >= 21 && currentHighScore < 25)
            {
                Ltwemty.SetActive(true);
                SceneManager.LoadScene("Level20");
            }
        }

        public void Levelone(){
            SceneManager.LoadScene("Level1");
        }

    }









