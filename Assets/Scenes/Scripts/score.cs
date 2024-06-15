using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public Text scoreText; // Reference to the UI Text component displaying the score
    public int scoreCount = 0; // Initialize the score to zero

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ball")) // Check if the collided object has the "ball" tag
        {
            GameObject.Find("WorkingBall").GetComponent<HoopManger2>().addscore();
        }
    }
}
