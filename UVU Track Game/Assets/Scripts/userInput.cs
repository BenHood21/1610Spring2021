using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userInput : MonoBehaviour
{
	public float speed = 3f;
	public float jumpForce = 3f;
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

	private void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name.Equals("Bullet"))
		{
			Debug.Log("Hit");
			Destroy(gameObject,0.1f);
		}
	}
}