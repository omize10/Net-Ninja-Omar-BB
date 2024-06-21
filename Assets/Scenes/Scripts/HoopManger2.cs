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
  //  private Sprite UB;

    public int highScoreTest;

    public inout inoutScript; // Reference to the Inout script
    //public SpriteRenderer backgounds;

    

    private void Awake()
    {
        if (_instance)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = gameObject;
        }

        
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
       
        //print("awak");

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

       // inoutScript = GameObject.Find("Main Camera").GetComponent<inout>();

        //inoutScript = Camera.main.GetComponent<inout>();
        if (inoutScript == null)
        {
            Debug.LogError("Inout script not found on the main camera.");
        }
    }
   /* public void UpdateBackgound(Sprite sprite)
    {
        backgounds.sprite = sprite;
        UB = sprite;
    } */
    private void Update()
    {
        
        //backgounds = GameObject.Find("BackGound").GetComponent<SpriteRenderer>();
        if (scoreText != null)
        {
            scoreText.text = currentScore.ToString();
            highscoreUpdate();
        }

       // backgounds.sprite = UB;
    }

    public void resetCurrentScore()
    {
        currentScore = 0;
    }

    public void highscoreUpdate()
    {
        if (currentScore >= hoopsRequired)
        {
            int currentHighScore = SceneManager.GetActiveScene().buildIndex - 5;

            Invoke("Wait", 7f);
            if (currentHighScore > previousHighScore)
            {
                PlayerPrefs.SetInt("HighScore", currentHighScore);
                PlayerPrefs.Save();
                highScoreTest = PlayerPrefs.GetInt("HighScore");

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
        Debug.Log(inoutScript);
        inoutScript.ZoomInAndOut(20f, 2f); // Adjust zoom amount and speed as needed
        if (inoutScript != null)
        {
            Debug.Log("1");
            inoutScript.ZoomInAndOut(20f, 2f); // Adjust zoom amount and speed as needed
        }
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

    public int GiveScore()
    {
        print(PlayerPrefs.GetInt("HighScore"));
        return PlayerPrefs.GetInt("HighScore");
    }
}
