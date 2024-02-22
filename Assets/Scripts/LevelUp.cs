using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUp : MonoBehaviour
{
    public void ReplayGame()
    {
        // Load the main scene (assuming it's at build index 0)
        SceneManager.LoadScene(2);
    }
}
