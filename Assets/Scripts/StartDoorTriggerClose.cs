using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartDoorTriggerClose : MonoBehaviour
{
    // creating gameobject and setting it as serialized field so it can be changed in the inspector 
    [SerializeField]
    GameObject startDoor;

    bool isOpened = false; // setting the trigger as false by default

    void OnTriggerEnter(Collider collider) // if something has collided with the object it will change the trigger to true and change the position of the gameobject thats set in the inspector
    {
        if (!isOpened)
        {
            isOpened = true;
            startDoor.transform.position += new Vector3(0, -4, 0);
        }
    }

}
