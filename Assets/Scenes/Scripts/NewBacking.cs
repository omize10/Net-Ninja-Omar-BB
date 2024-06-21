/* using System.Collections;
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
        Debug.Log("EqquiWorking");
        var script = HM2.GetComponent<HoopManger2>();
        script.UpdateBackgound(NBSprit);
        Time.timeScale = 1.0f;
        OnBack.SetActive(false);
        DC.SetActive(true);
        Destroy(gameObject);
    }

    public void End()
    {
        Debug.Log("EndSyetemwoks");
        Time.timeScale = 1.0f;
        OnBack.SetActive(false);
        DC.SetActive(true);
        Destroy(gameObject);
        // try to remove gameobject from in gameobject or may have to do form outside gameobject
    }
}
*/