using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text scoreText; // Reference to the UI Text component displaying the score
    public int scoreCount = 0; // Initialize the score to zero

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball")) // Check if the collided object has the "ball" tag
        {
            scoreCount++; // Increment the score
            scoreText.text = scoreCount.ToString(); // Update the UI text with the new score
            
            // Check if the player has reached the required points for level completion
            if (scoreCount >= 2)
            {
                // Load the level completion scene (replace with your actual scene name)
                SceneManager.LoadScene("LevelCompleteScene");
            }

            Destroy(collision.gameObject); // Destroy the ball object
        }
    }
}
