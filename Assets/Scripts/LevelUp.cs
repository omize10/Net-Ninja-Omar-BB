using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelUp : MonoBehaviour
{


    //public int thing = 7;

    private void Start()
    {
        //thing += 1;
    }
    public void ReplayGame()
    {
        // Load the main scene (assuming it's at build SceneManager.GetActiveScene().buildIndexindex 0)
        //SceneManager.LoadScene(thing);

        if(SceneManager.GetActiveScene().buildIndex == 6)
        {
            SceneManager.LoadScene(1);
        }


        //only loads first scene once replay game function is clicked and called 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
