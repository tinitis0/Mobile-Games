using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_Menu : MonoBehaviour
{
    // creating gameobject and setting it as serialized field so it can be changed in the inspector 
    [SerializeField] private GameObject TutorialMenuUI;

    bool isActive = false;// setting the trigger as false by default

    public void TutorialMenu() // once the button is pressed it triggers the menu. if the menu is not active it will turn the menu true and show the tutorial menu
    {
        if (isActive)
        {
            TutorialMenuUI.SetActive(false);
            isActive = false;
        }
        else
        {
            TutorialMenuUI.SetActive(true);
            isActive = true;
        }
    }
}
