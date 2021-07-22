using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPressurePlate : MonoBehaviour
{
    // creating gameobjects and setting them as serialized field so they can be changed in the inspector 
    [SerializeField]
    GameObject Block1;
    [SerializeField]
    GameObject Block2;
    [SerializeField]
    GameObject Gate;

    bool isActive = false;
    
                                   
    void OnTriggerEnter(Collider col)  // if something has collided with the object it will change the trigger to true and change the position of the gameobjects thats set in the inspector
    {
        if (!isActive)
        {
            isActive = true;
            Block1.transform.position += new Vector3(0, 3f, 0);
            Block2.transform.position += new Vector3(0, 3f, 0);
            Gate.transform.position += new Vector3(0, 2.2f, 0);
        }
    }

    void OnTriggerExit(Collider col) // if something has collided with the object it will change the trigger to false and change the position of the gameobjects back to their original positions
    {
        if (isActive)
        {
            isActive = false;
            Block1.transform.position += new Vector3(0, -3f, 0);
            Block2.transform.position += new Vector3(0,-3f, 0);
            Gate.transform.position += new Vector3(0, -2.2f, 0);
        }
    }

}
