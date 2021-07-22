using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTrigger : MonoBehaviour
{
    public Transform spawnpoint; // creates spawnpoint for an gameobject can be changed in theninspector
    public Rigidbody Prefab; // creates a field in the inspector to assign object with rigidbody 

    bool isTriggered = false;

    void OnTriggerEnter() // if something has collided with the object it will change the trigger to true and get rigid body prefab thats set in the inspector, and then make it appear at the set spawnpoint
    {
        if (!isTriggered)
        {
            isTriggered = true;
            Rigidbody RigPrefab;
            RigPrefab = Instantiate(Prefab, spawnpoint.position, spawnpoint.rotation)as Rigidbody;
        }
        
    }

 
}
