using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HRMagemnt : MonoBehaviour
{
    private HoopManger2 workball;
    public int hoopRequired;
    public Text scoreText;
    public GameObject IMG;
    void Start()
    {
        workball = GameObject.Find("WorkingBall").GetComponent<HoopManger2>();
        workball.hoopsRequired = hoopRequired;
        workball.scoreText = scoreText;
        workball.IMG = IMG;
    }

    
    void Update()
    {
        
    }
}
