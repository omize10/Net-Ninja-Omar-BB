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

  private void Awake()
    {
        
        int hiiScore = GameObject.Find("WorkingBall").GetComponent<HoopManger2>().highScoreTest;
        Debug.Log(hiiScore);
        //LevelTen();
        //LevelFifteen();
        //LevelTwenty();
    }

    void Update()
    {
        int hiiScore = GameObject.Find("WorkingBall").GetComponent<HoopManger2>().highScoreTest;


        if (hiiScore >= 10 )//&& hiiScore < 12)
        {
            Lten.SetActive(true);
            
        }
        if (hiiScore >= 15)// && hiiScore < 16)
        {
            LFifteen.SetActive(true);
          
        }
        if (hiiScore >= 20 )//&& hiiScore < 25)
        {
            Ltwemty.SetActive(true);
          
        }

    }

     public void LevelTen()
    {
        int hiiScore = GameObject.Find("WorkingBall").GetComponent<HoopManger2>().highScoreTest;
        if (hiiScore >= 10 )//&& hiiScore < 12)
        {
            //Lten.SetActive(true);
            SceneManager.LoadScene("Level10");
        }

    }

    public void LevelFifteen()
    {

        int hiiScore = GameObject.Find("WorkingBall").GetComponent<HoopManger2>().highScoreTest;
        if (hiiScore >= 15)// && hiiScore < 16)
        {
          //  LFifteen.SetActive(true);
            SceneManager.LoadScene("Level15");
        }

    }
        public void LevelTwenty()
        {
        int hiiScore = GameObject.Find("WorkingBall").GetComponent<HoopManger2>().highScoreTest;
        if (hiiScore >= 20)// && hiiScore < 25)
            {
                //Ltwemty.SetActive(true);
                SceneManager.LoadScene("Level20");
            }
        }

        public void Levelone(){
            SceneManager.LoadScene("Level1");
        }

    public void Creidts()
    {
        SceneManager.LoadScene("Credits");
    }

    }









