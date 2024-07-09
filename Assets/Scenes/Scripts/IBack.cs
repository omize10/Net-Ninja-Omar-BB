using UnityEngine;
using UnityEngine.SceneManagement;

public class IBack : MonoBehaviour
{
    public GameObject Conl;

    public void Start()
    {
        //Conl = GameObject.Find("Backup");
    }
    public void ReplayGame()
    {
        // Load the main scene (assuming it's at build index 0)
        Time.timeScale = 1;
        SceneManager.LoadScene("Home");
        
    }

    public void Keep()
    {
        Conl.SetActive(false);
        Time.timeScale = 1;
    }
    public void Backbutton()
    {
        Conl.SetActive(true);
        Time.timeScale = 0;
    }
}