using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userInput : MonoBehaviour
{
	public Rigidbody2D ballRigidbody2D;
	public float speed = 3f;
	public float jumpForce = 300f;
	
	private Vector2 direction;
	private Vector2 yDirection;
	
    void Update()
    {
	       direction.x = Input.GetAxis("Horizontal") * speed;
		    ballRigidbody2D.AddForce(direction, ForceMode2D.Force);
		   
		    if (Input.GetButtonDown("Jump"))
		    {
			    yDirection.y = jumpForce;
			    ballRigidbody2D.AddForce(yDirection, ForceMode2D.Force);
		    }

    }
}	