using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Animator))]
public class Actions : MonoBehaviour {

	private Animator animator;	
    // get the animatior once its awake on scene
	void Awake () {
		animator = GetComponent<Animator> ();
	}

    // stand still animation
	public void Stay () {
		animator.SetBool("Aiming", false);
		animator.SetFloat ("Speed", 0f);
		}
    	// Run animation
	public void Run () { 
		animator.SetBool("Aiming", false);
		animator.SetFloat ("Speed", 1f);
	}	  
	// jump animation
	public void Jump () {
		animator.SetBool ("Squat", false);
		animator.SetFloat ("Speed", 0f);
		animator.SetBool("Aiming", false);
        animator.SetTrigger ("Jump");
	}

}
