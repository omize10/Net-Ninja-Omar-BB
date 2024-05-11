using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieStar : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            Invoke("", 2f);


            Destroy(gameObject);
        }
    }
}
