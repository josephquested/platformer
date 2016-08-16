using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {
	Rigidbody rb;
	public float minHeight;
	public float maxHeight;
	public float minSpeed;
	public float maxSpeed;

	void Awake ()
	{
		rb = GetComponent<Rigidbody>();
		Destroy(gameObject, 30);
	}

	public void Fire (bool isFiringLeft)
	{
		if (isFiringLeft)
		{
			rb.AddForce(-Vector3.right * Random.Range(minSpeed, maxSpeed));
		}
		else
		{
			rb.AddForce(Vector3.right * Random.Range(minSpeed, maxSpeed));
		}
	}

	void Break ()
	{
		rb.velocity = Vector3.zero;
	}

	void OnCollisionEnter (Collision collision)
	{
		if (collision.gameObject.tag == "Platform")
		Destroy(gameObject);
  }
}
