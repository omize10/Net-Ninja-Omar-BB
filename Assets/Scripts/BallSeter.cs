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
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {

        HM2 = GameObject.Find("ball").GetComponent<HoopManger2>();
        //buttons = GameObject.FindGameObjectsWithTag("EquipArry");
        //amountOfBallsUnlocked += 1;
        

        if (HM2.hasHappened)
        {
            amountOfBallsUnlocked += 1;
            if (amountOfBallsUnlocked != 0)
            {
                print("this has happened");


                print(amountOfBallsUnlocked);
                for (int i = 0; i < amountOfBallsUnlocked; i++)
                {
                    print("working");
                    //setcurrent button to atctive( number that is set to amountOfBallsUnlocked)
                    currentButton = buttons[0];
                    currentButton.SetActive(true);
                }
                //GameObject currentButton = buttons[amountOfBallsUnlocked];
                //currentButton.SetActive(true);  
                print("Almost done");
                HM2.hasHappened = false;
            }
        }
    }


    void Update()
    {
        
    }


}
