using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gems : MonoBehaviour
{
    // sets Gem score to 0 by default;
    static int GemsScore = 0;

    public Text GemDesplay;

    void OnTriggerEnter(Collider col) 
    {
        if (col.gameObject.tag == "Player") // if the object comes in contact with gameobject tagged "Player" it does fallowing...
        {
            GemsScore ++; // adds +1 to  gems collected
            GemDesplay.text = GemsScore.ToString(); // changes the int to string;
            Destroy(gameObject); // destroys game object (Gem)
        }
    }
}
