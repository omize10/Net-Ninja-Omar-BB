using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HoopManger2 : MonoBehaviour
{ // ******* every time you beat your highscore you unlcok new backgound *******!!!!!!!!!!!!!!
    public Text scoreText;
    public GameObject IMG;

    public int hoopsRequired = 3; 
    //public GameObject hoop;
    private int currentScore = 0;
    private int previousHighScore;

    public bool hasHappened;
    
    void wait()
    {
        IMG.SetActive(false);
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        //PlayerPrefs.SetInt("HighScore", 0);//DELETE THIS LINE AFTER RESETTING HIGH SCORE
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

                
                
                if (SceneManager.GetActiveScene().buildIndex > previousHighScore)
                {
                    previousHighScore = SceneManager.GetActiveScene().buildIndex - 7;
                    
                    PlayerPrefs.SetInt("HighScore", previousHighScore);
                    PlayerPrefs.Save();

                    IMG.SetActive(true);
                    Invoke("wait", 100f);


                    hasHappened = true; 


                    

                }
                SceneManager.LoadScene("LevelUp#1");
            }
        }
    }
}




