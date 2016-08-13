using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	Rigidbody rb;
	public bool isGrounded;
	public float speed = 6.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		ApplyGravity();
	}

	public void RecieveMovementInput (float horizontal)
	{
		Vector3 movement = new Vector3(horizontal * speed, 0, 0);
		if (!isGrounded) movement = movement / 2;
		rb.AddForce(movement);
	}

	public void RecieveJumpInput (bool jump)
	{
		if (jump && isGrounded)
		{
			rb.AddForce(Vector3.up * jumpSpeed);
		}
	}

	void ApplyGravity ()
	{
		if (!isGrounded)
		{
			rb.AddForce(Vector3.down * gravity);
		}
	}

	void OnCollisionStay (Collision collisionInfo)
		{
			isGrounded = true;
		}

	void OnCollisionExit (Collision collisionInfo)
		{
			isGrounded = false;
		}

	void OnTriggerExit (Collider collider)
	{
		if (collider.tag == "Bounds")
		{
			GameObject.FindWithTag("GameManager").GetComponent<GameManager>().Restart();
		}
	}
}
