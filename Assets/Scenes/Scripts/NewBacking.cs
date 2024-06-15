using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBacking : MonoBehaviour
{
    public GameObject HM2;
    //public GameObject Ball;
    public GameObject OnBack;
    //public GameObject CTD;
   // public GameObject Timer;
    public GameObject DC;
    public Sprite NBSprit;
    void Start()
    {
        HM2 = GameObject.Find("WorkingBall");
        var script = HM2.GetComponent<HoopManger2>();
        DC = GameObject.Find("DragController");

        Debug.Log("sart");
    }

    
    void Update()
    {
          
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ball"))
        {
            Debug.Log("here");
            //Timer.SetActive(false);
            DC.SetActive(false);
            Time.timeScale = 0.0f;
            OnBack.SetActive(true);
           
            
        }
    }

    public void Eqqui()
    {
        var script = HM2.GetComponent<HoopManger2>();
        script.UpdateBackgound(NBSprit);
    }
}
