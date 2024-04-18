using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSeter : MonoBehaviour
{
    public GameObject[] buttons;
    public HoopManger2 HM2;
    public int amountOfBallsUnlocked = 0;


    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    void Start()
    {
        HM2 = GameObject.Find("ball").GetComponent<HoopManger2>();
        //buttons = GameObject.FindGameObjectsWithTag("EquipArry");
        amountOfBallsUnlocked += 1;
    }


    void Update()
    {
        if (HM2.hasHappened = true)
        {
            GameObject currentButton = buttons[amountOfBallsUnlocked];
            currentButton.SetActive(true);
            HM2.hasHappened = false;
        }
    }


}
