using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HoopManger2 : MonoBehaviour
{
    public Text scoreText; // Reference to the UI Text component displaying the score
    public int hoopsRequired = 3; // Number of hoops required to complete the level
    public GameObject hoop;
    private int currentScore = 0;
    private int previousHighScore;

    private void Start()
    {
        previousHighScore = PlayerPrefs.GetInt("HighScore", 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Score"))
        { 

            currentScore++;
            scoreText.text = "Score: " + currentScore;

            //Destroy(collision.gameObject); // Destroy the hoop itself

            if (currentScore >= hoopsRequired)
            {
                // Load the level completion scene (replace with your actual scene name)
                if(SceneManager.GetActiveScene().buildIndex > previousHighScore)
                {
                    previousHighScore = SceneManager.GetActiveScene().buildIndex;
                    
                    PlayerPrefs.SetInt("HighScore", previousHighScore);
                    PlayerPrefs.Save();
                }
                SceneManager.LoadScene("LevelUp#1");
            }
        }
    }
}




