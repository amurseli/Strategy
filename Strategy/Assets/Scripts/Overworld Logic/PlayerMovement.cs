using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController controller;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;

	bool movementAllowed = true;

	
	// Update is called once per frame
	void Update () {
		if(movementAllowed){
			horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

			if (Input.GetButton("Jump"))
			{
				jump = true;
			}
		}

	}

	public void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
		jump = false;
	}

	public void resumeAllMovement(){
		if(!movementAllowed){
			movementAllowed = true;	
		}
	}

	public void stopAllMovement(){
		if(movementAllowed){
			movementAllowed = false;	
		}
	}

}