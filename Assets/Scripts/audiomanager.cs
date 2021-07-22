using UnityEngine;
using UnityEngine.Audio;
using System;

public class audiomanager : MonoBehaviour
{
    
     void Awake()
     {
        DontDestroyOnLoad(gameObject);        // doesnt desctroy the game object when the scene changes
     }


}
