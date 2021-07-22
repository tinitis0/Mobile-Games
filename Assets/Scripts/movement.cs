using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
     // creating protected and public fields for the UI elements that can be adjusted/changed in the inspector
    protected Joystick leftJoystick;
    protected FixedButton jumpButton;
    public FixedTouchField Touchfield;

    //accessing the animator through this script
    Animator m_animator;

    // creating bools for jumping and checking if the character is in the air or not
    protected bool jump;    
    protected bool InAir = false;
    
    // creating parameters for the main camera
    protected float CameraAngleY;
    protected float CameraAngleSpeed = 0.2f;
    protected float CameraPosY;
    protected float CameraPosSpeed = 0.2f;
        

    // Start is called before the first frame update
    void Start()
    {
        leftJoystick = FindObjectOfType<Joystick>();
        jumpButton = FindObjectOfType<FixedButton>();
        m_animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();

       
        //character Jumping
        //if character is not jumping and jump button is pressed and the character is not InAir then jump is true
        if (!jump && jumpButton.Pressed && InAir ==false)
        {
            jump = true;
            rigidbody.velocity += Vector3.up * 7.5f;  
        }
        //if character is set to jump but the jump button is not pressed then jump is changed to false
        if (jump && !jumpButton.Pressed)
        {
            jump = false;            
        }

        // character controls
        var Input = new Vector3(leftJoystick.Horizontal * 7, rigidbody.velocity.y, leftJoystick.Vertical * 7);
        var vel = Quaternion.AngleAxis(CameraAngleY + 180, Vector3.up) * Input;

        rigidbody.velocity = new Vector3(vel.x, rigidbody.velocity.y, vel.z);
        transform.rotation = Quaternion.AngleAxis(CameraAngleY + 180 + Vector3.SignedAngle(Vector3.forward, Input.normalized + Vector3.forward * 0.001f, Vector3.up), Vector3.up);
        CameraAngleY += Touchfield.TouchDist.x * CameraAngleSpeed;
        // transforming the camera
        Camera.main.transform.position = transform.position + Quaternion.AngleAxis(CameraAngleY, Vector3.up) * new Vector3(0, 3, 3);
        Camera.main.transform.rotation = Quaternion.LookRotation(transform.position + Vector3.up * 2f - Camera.main.transform.position, Vector3.up);

       ////////////////////////////////////// //Animator//////////////////////////////////////

        // calling jumping animation in the animator
        bool isjumping = rigidbody.velocity.y > 6.9f; // creates bool for jumping with parameters
        m_animator.SetBool("Jump", isjumping);    // calls the animator and sets the bool for the Jump animation
       

        //calling running animation in the animator;
        bool isrunning = rigidbody.velocity.x > 0.3f || rigidbody.velocity.z > 0.3f || rigidbody.velocity.x < -0.3f || rigidbody.velocity.z < -0.3f; // creates bool for running with parameters
        m_animator.SetBool("Run", isrunning);     // calls the animator and sets the bool for the Run animation

    }


    // checks if the player has colided with game object tagged as "untagged" then InAir is set to false 
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Untagged")
        {
            InAir = false;
        }
    }

    //checks if the player is coliding with gameobject tagged as "untagged" and is above 0 point, then InAir is set to false
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Untagged" && InAir == true)
        {
            InAir = false;           
        }
    }

    // checks when player exits collision with game objects meaning that the player is in jump action.
    void OnCollisionExit(Collision collision)
    {
        InAir = true;        
    }




}
