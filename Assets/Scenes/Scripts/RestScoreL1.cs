using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestScoreL1: MonoBehaviour
{
    public HoopManger2 hoopManger2;
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("WorkingBall").GetComponent<HoopManger2>();
        hoopManger2.resetCurrentScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
