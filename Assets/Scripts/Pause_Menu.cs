using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;



public class Pause_Menu : MonoBehaviour
{

    [SerializeField] private GameObject pauseMenuUI;

    bool isPaused = false; // sets the pause UI to false by default

    //Pause game 
    public void pauseGame()
    {
        if (isPaused)
        {
            pauseMenuUI.SetActive(false);   // if the button is not pressed, sets the Pause UI as false         
            isPaused = false;
        }
        else
        {
            pauseMenuUI.SetActive(true);      // if the button is not pressed, sets the Pause UI as true         
            isPaused = true;
        }
    }

    // restart current level
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    //load main menu
    public void MainMenu()
    {
        SceneManager.LoadScene(0); 
    }


}