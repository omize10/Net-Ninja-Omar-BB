/*using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float totalTime = 30.0f; // Updated to 30 seconds
    private float elapsedTime = 0.0f;
    public Text timerText;

    void Start()
    {
        timerText = GameObject.Find("TimerText").GetComponent<Text>();
    }

    void Update()
    {
        if (elapsedTime < totalTime)
        {
            elapsedTime += Time.deltaTime;
            UpdateTimerDisplay();
        }
        else
        {
            // Time's up! Implement your desired actions here.
            Debug.Log("Time's up!");
        }
    }

    void UpdateTimerDisplay()
    {
        int seconds = Mathf.FloorToInt(totalTime - elapsedTime); // Countdown from totalTime

        // Format the time as "mm:ss"
        string formattedTime = string.Format("{0:00}:{1:00}", seconds / 60, seconds % 60);

        timerText.text = formattedTime;
    }
}
*/


using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Import the necessary namespace for scene management

public class CountdownTimer : MonoBehaviour
{
    public float totalTime = 30.0f; // Updated to 30 seconds
    private float elapsedTime = 0.0f;
    public Text timerText;

    void Start()
    {
        timerText = GameObject.Find("TimerText").GetComponent<Text>();
    }

    void Update()
    {
        if (elapsedTime < totalTime)
        {
            elapsedTime += Time.deltaTime;
            UpdateTimerDisplay();
        }
        else
        {
            // Time's up! Implement your desired actions here.
            Debug.Log("Time's up!");

            // Load a new scene (replace "YourSceneName" with your actual scene name)
            //GameObject kill = GameObject.Find("WorkingBall");
          //  Destroy(kill);
            SceneManager.LoadScene("Gameover");
        }
    }

    void UpdateTimerDisplay()
    {
        int seconds = Mathf.FloorToInt(totalTime - elapsedTime); // Countdown from totalTime

        // Format the time as "mm:ss"
        string formattedTime = string.Format("{0:00}:{1:00}", seconds / 60, seconds % 60);

        timerText.text = formattedTime;
    }
}
