using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionChecker : MonoBehaviour
{
    public Text scoreText; 
    public Score scriptscore;
    public GameObject hop;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ball")) 
        {
             Debug.Log("Ball collided with hoop!");
            scriptscore.scoreCount++; 
            scoreText.text = scriptscore.scoreCount.ToString();
            Debug.Log("dd");
            Destroy(gameObject);

             if (scriptscore.scoreCount >= 2)
            {
                // Load the level completion scene (replace with your actual scene name)
                SceneManager.LoadScene(5);
            }
        }
    }
}
