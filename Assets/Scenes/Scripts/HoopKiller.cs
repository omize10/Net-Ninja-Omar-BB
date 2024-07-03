using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoopKiller : MonoBehaviour
{

    public AudioSource WooshSound;
    public GameObject workingBall;
    public GameObject Complent;
    void Start()
    {
        WooshSound = GameObject.Find("WorkingBall").GetComponent<AudioSource>();
        WooshSound.time = 0.2f;
    }


    void Update()
    {
        //finds all of gameobjects tagged ball
        // 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            WooshSound.Play();
            gameObject.SetActive(false);
            Invoke("", 2f);
            
            Complent.SetActive(true);
            Invoke("waitc", 3);
            


        }
    }

    void waitc()
    {
        Complent.SetActive(false);
        //Destroy(gameObject);
        

    }
    
}