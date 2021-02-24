using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public GameObject winTextObject;

	private float movementX;
	private float movementY;

	private Rigidbody rb;



	void Start()
	{

		rb = GetComponent<Rigidbody>();


		winTextObject.SetActive(false);
	}

	void FixedUpdate()
	{

		Vector3 movement = new Vector3(movementX, 0.0f, movementY);

		rb.AddForce(movement * speed);
	}

	void OnTriggerEnter(Collider other)
	{

		if (other.gameObject.CompareTag("Flag"))
		{
			other.gameObject.SetActive(false);
				winTextObject.SetActive(true);
		}
	}

	void OnMove(InputValue value)
	{
		Vector2 v = value.Get<Vector2>();

		movementX = v.x;
		movementY = v.y;
	}
}

