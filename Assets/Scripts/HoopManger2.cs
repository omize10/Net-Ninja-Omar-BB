using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HoopManger2 : MonoBehaviour
{ // ******* every time you beat your highscore you unlcok new backgound *******!!!!!!!!!!!!!!
    public Text scoreText;
    public GameObject IMG;

    public int hoopsRequired = 2;
    //public GameObject hoop;
    public int currentScore = 0;
    private int previousHighScore;
    
    
    public bool hasHappened;

    void wait()
    {
        IMG.SetActive(false);
    }

    private void Awake()
    {
        // if (// not in destroy ball scene)
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        //PlayerPrefs.SetInt("HighScore", 0);//DELETE THIS LINE AFTER RESETTING HIGH SCORE
        previousHighScore = PlayerPrefs.GetInt("HighScore", 0);

        scoreText = GameObject.Find("Score Text").GetComponent<Text>();
    }

    private void Update()
    {
        scoreText.text = currentScore.ToString();
        highscoreUpdate();
        
    }

   public void highscoreUpdate()
    {
        //Destroy(collision.gameObject); // Destroy the hoop itself
       
        if (currentScore >= hoopsRequired)
        {

            print("watch");
            int currentHighScore = SceneManager.GetActiveScene().buildIndex - 7;
            if (currentHighScore > previousHighScore)
            {
                PlayerPrefs.SetInt("HighScore", currentHighScore);
                PlayerPrefs.Save();

                IMG.SetActive(true);
                Invoke("wait", 300f);


                hasHappened = true;




            }
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void addscore()
    {
        currentScore++;
       
    }
}




