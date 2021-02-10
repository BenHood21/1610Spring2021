using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userInput : MonoBehaviour
{
	public float speed = 3f;
	public float jumpForce = 20f;
	public Rigidbody2D rigidbodyObj;
	private Vector2 direction;

	private void Update()
	{
		direction.x = speed * Input.GetAxis("Horizontal");
		rigidbodyObj.AddForce(direction, ForceMode2D.Force);
		if (Input.GetButtonDown("Jump"))
		{ 
			direction.y = jumpForce;
			rigidbodyObj.AddForce(direction, ForceMode2D.Impulse);
		}
	}
}