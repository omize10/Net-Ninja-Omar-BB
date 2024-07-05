using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    // This method is called when the replay button is clicked
    public void ReplayGame()
    {
        // Load the main scene (assuming it's at build index 0)
        SceneManager.LoadScene("Checkpointloader");
    }
}