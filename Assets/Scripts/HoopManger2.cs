using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HoopManger2 : MonoBehaviour
{
    public Text scoreText; // Reference to the UI Text component displaying the score
    public int hoopsRequired = 1; // Number of hoops required to complete the level
    public GameObject hoop;
    private int currentScore = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ball"))
        {
            Debug.Log("Ball collided with hoop!");
            currentScore++;
            scoreText.text = "Score: " + currentScore;
            Debug.Log("Bal!");
            Destroy(hoop); // Destroy the hoop itself

            if (currentScore >= hoopsRequired)
            {
                // Load the level completion scene (replace with your actual scene name)
                SceneManager.LoadScene(6);
            }
        }
    }
}




