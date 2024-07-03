using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bounce : MonoBehaviour
{
    public float ypos;
    void Start()
    {
        ypos = 18;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            Debug.Log("Runing");
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Debug.Log("NowW");
                rb.AddForce(new Vector2(0, ypos), ForceMode2D.Impulse);
            }
        }
    }
}
