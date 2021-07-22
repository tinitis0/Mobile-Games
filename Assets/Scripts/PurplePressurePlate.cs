using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurplePressurePlate : MonoBehaviour
{
    // creating gameobjects and setting them as serialized field so they can be changed in the inspector 
    [SerializeField]
    GameObject SmallGate2;
    [SerializeField]
    GameObject SmallGate3;


    bool isActive = false; // setting the trigger as false by default


    void OnTriggerEnter(Collider col) // if something has collided with the object it will change the trigger to true and change the position of the gameobjects thats set in the inspector
    {
        if (!isActive)
        {
            isActive = true;
            SmallGate2.transform.position += new Vector3(0, 0, -3f);
            SmallGate3.transform.position += new Vector3(4f, 0, 0);
        }
    }

    void OnTriggerExit(Collider col) // if something has collided with the object it will change the trigger to false and change the position of the gameobjects back to their original positions
    {
        if (isActive)
        {
            isActive = false;
            SmallGate2.transform.position += new Vector3(0, 0, 3f);
            SmallGate3.transform.position += new Vector3(-4f, 0, 0);
        }
        
    }
}
