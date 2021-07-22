using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    //load scenes using scenemanager

    public void MainMenuScene() // main menu scene
    {
        SceneManager.LoadScene(0);
    }
    public void PlayGame() // level select scene
    {
        SceneManager.LoadScene(1);
    }

    public void OptionsMenu() // options menu scene
    {
        SceneManager.LoadScene(2);
    }   

    public void Tutorial() // tutorial scene
    {
        SceneManager.LoadScene (3);
    }

    public void Level_1() // level 1 scene
    {
        SceneManager.LoadScene(4);
    }

    public void Level_2() // level 2 scene
    {
        SceneManager.LoadScene(5);
    }



    public void QuitGame() // Exit the game script

    {
        Application.Quit();
    }

}
