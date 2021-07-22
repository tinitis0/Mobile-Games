using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCamera : MonoBehaviour
{

    public float speed; // speed variable which can be changed in inspector
 

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, speed * Time.deltaTime, 0); //rotating camera on y axis, by using speed variable and time.
    }
}
