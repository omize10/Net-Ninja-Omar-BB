using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



// ******* every time you beat your highscore you unlcok new backgound *******!!!!!!!!!!!!!!
public class PointsMangment : MonoBehaviour
{
    private int previousHighScore;
    public Text highScoreText;  // Reference to a Text component to display the high score
    private int test;
   

    // Start is called before the first frame update
    void Awake()
    {
        // Load the previous high score from PlayerPrefs
        UpdateHighScoreText();
    }

    public void UpdateHighScoreText()
    {
        // update the score text
        //previousHighScore = PlayerPrefs.GetInt("HighScore");
        
        //for testing purposes
       // Debug.Log(highscorething);
        int highscorething = GameObject.Find("WorkingBall").GetComponent<HoopManger2>().highScoreTest;

        highScoreText.text = highscorething.ToString();
    }
}
