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
   

    // Start is called before the first frame update
    void Start()
    {
        // Load the previous high score from PlayerPrefs
        previousHighScore = PlayerPrefs.GetInt("HighScore", 0);
        Debug.Log(previousHighScore);
        UpdateHighScoreText();
    }

    public void UpdateHighScoreText()
    {
        // update the score text
        highScoreText.text = previousHighScore.ToString();
    }
    void Update()
    {
        
    }
}
