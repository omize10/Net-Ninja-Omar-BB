using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Required for scene management

public class score : MonoBehaviour
{
    public Text scoreText; // Reference to the UI Text component displaying the score
    public int Scorecount = 0; // Initialize the score to zero

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ball")) // Check if the collided object has the "ball" tag
        {
            Scorecount++; // Increment the score
            scoreText.text = Scorecount.ToString(); // Update the UI text with the new score

            // Check if the player has reached the required points for level completion
            if (Scorecount >= 2)
            {
                // Load the level completion scene //(replace with your actual scene name)
               SceneManager.LoadScene(5);
            }
        }
    }
}
