using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSystem : MonoBehaviour
{
    public int points;

    void Start()
    {

    }


    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("star"))
        {
            points++;




        }
    }
}
