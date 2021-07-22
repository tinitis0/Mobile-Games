using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePressurePlate : MonoBehaviour
{
    // creating gameobject and setting it as serialized field so it can be changed in the inspector 
    [SerializeField]
    GameObject Door1;
   
    bool isActive = false; // setting the trigger as false by default


    void OnTriggerEnter(Collider col) // if something has collided with the object it will change the trigger to true and change the position of the gameobject thats set in the inspector
    {
        if (!isActive)
        {
            isActive = true;
            Door1.transform.position += new Vector3(0, 5f, 0);            
        }
    }

    void OnTriggerExit(Collider col) // if the object stops collidion with the trigger then  it resets the game objects back to its original position
    {
        if (isActive)
        {
            isActive = false;
            Door1.transform.position += new Vector3(0, -5f, 0);
        }
    }
}
