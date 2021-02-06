using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userInput : MonoBehaviour
{
	public Rigidbody2D ballRigidbody2D;
	public float speed = 3f;
	public float jumpForce = 15f;
	
	private Vector2 direction;
	private Vector2 yDirection;

	private int score;
	
	private void Update()
	{
		direction.x = Input.GetAxis("Horizontal");
		if (Input.GetButtonDown("Jump")) return;
		yDirection.y = jumpForce;
	}
	private  void FixedUpdate()
	{
		var newDirection = direction * (speed * Time.deltaTime);
		ballRigidbody2D.AddForce(direction, ForceMode2D.Force);
		ballRigidbody2D.AddForce(yDirection, ForceMode2D.Force);
	}
}	