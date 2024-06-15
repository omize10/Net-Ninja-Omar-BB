using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBacking : MonoBehaviour
{
    public GameObject HM2;
    public GameObject Ball;
    void Start()
    {
        HM2 = GameObject.Find("Working Ball");
        var script = HM2.GetComponent<HoopManger2>();
        Ball = GameObject.Find("ballOG");
    }

    
    void Update()
    {
          
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ball"))
        {
            Time.timeScale = 0.0f;
        }
    }
}
