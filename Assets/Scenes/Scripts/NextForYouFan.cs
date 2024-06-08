using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextForYouFan : MonoBehaviour
{
 
    public void ReplayGame()
    {
        // Load the main scene (assuming it's at build index 0)
        SceneManager.LoadScene("YouFan 1");
    }
}
