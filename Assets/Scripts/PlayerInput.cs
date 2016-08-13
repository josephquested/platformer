using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {
	Movement movement;

	void Start ()
	{
		movement = GetComponent<Movement>();
	}

	void FixedUpdate ()
	{
		MovementInput();
	}

	void Update ()
	{
		JumpInput();
	}

	void MovementInput ()
	{
		movement.RecieveMovementInput(Input.GetAxis("Horizontal"));
	}

	void JumpInput ()
	{
		movement.RecieveJumpInput(Input.GetButtonDown("Jump"));
	}

	void OnTriggerExit (Collider collider)
	{
		if (collider.tag == "Bounds")
		{

		}
	}
}
