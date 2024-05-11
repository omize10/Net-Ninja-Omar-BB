using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HoopManger2 : MonoBehaviour
{
    // Singleton
    public static GameObject _instance;

    public Text scoreText;
    public GameObject IMG;
    public SpriteRenderer ballSpriteRenderer;
    //public Sprite[] ballSprites;

    public int hoopsRequired = 2;
    public int currentScore = 0;
    private int previousHighScore;
    public bool hasHappened;

    private void Awake()
    {
        if (_instance)
        {
            Destroy(gameObject);
        } else
        {
            _instance = gameObject;
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        if (scoreText != null)
        {
            previousHighScore = PlayerPrefs.GetInt("HighScore", 0);
            scoreText = GameObject.Find("Score Text").GetComponent<Text>();

            GameObject ball = GameObject.FindGameObjectWithTag("Ball");
            if (ball != null)
            {
                ballSpriteRenderer = ball.GetComponent<SpriteRenderer>();
            }
        }
    }

    private void Update()
    {
        if(scoreText != null)
        {
            scoreText.text = currentScore.ToString();
            highscoreUpdate();
        }
    }

    public void highscoreUpdate()
    {
        if (currentScore >= hoopsRequired)
        {
            int currentHighScore = SceneManager.GetActiveScene().buildIndex - 5;
            if (currentHighScore > previousHighScore)
            {
                PlayerPrefs.SetInt("HighScore", currentHighScore);
                PlayerPrefs.Save();


                //if (currentHighScore < ballSprites.Length)
                //{
                  //  ballSpriteRenderer.sprite = ballSprites[currentHighScore];
               // }
               // }

                IMG.SetActive(true);
                Invoke("Wait", 3f);

                hasHappened = true;
            }
            currentScore = 0;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void addscore()
    {
        currentScore++;
    }

    void Wait()
    {
        IMG.SetActive(false);
    }

    // Method to change the ball's image
    public void ChangeBallImage(Sprite newImage)
    {
        if (ballSpriteRenderer != null)
        {
            ballSpriteRenderer.sprite = newImage;
        }
    }
}

