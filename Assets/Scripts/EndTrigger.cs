using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{

    public GameObject EndLevelMenu;

   
    // once the finish is touched and triggered it opens end level menu
    private void OnTriggerEnter()
    {
       EndLevelMenu.SetActive(true);        
    }
    // Load next level in the build index
    public void Nextlevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
