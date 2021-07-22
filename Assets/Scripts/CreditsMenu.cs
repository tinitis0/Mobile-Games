using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsMenu : MonoBehaviour
{
    [SerializeField] private GameObject CreditMenuUI;  // creating private game object that serialized so it shows in the inspector

    [SerializeField] private GameObject OptionsMenuUI; // creating private game object that serialized so it shows in the inspector
    
    bool isActive = false; // creating bool thats false by default

    // Credits menu UI
    public void CreditMenu()
    {
        if (isActive) // if the UI is not active it will  set the menu true once the button is pressed 
        {
            CreditMenuUI.SetActive(false);
            isActive = false;
            OptionsMenuUI.SetActive(true);
        }
        else // of the menu is acitve it will dissable the menu if the  back button is pressed
        {
            CreditMenuUI.SetActive(true);
            isActive = true;
            OptionsMenuUI.SetActive(false);

        }
    }
}
