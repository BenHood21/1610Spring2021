using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class userInput : MonoBehaviour
{
	
	public Rigidbody2D ballRigidbody2D;
	public Vector2 direction;

	public Vector2 yDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKey(KeyCode.RightArrow))
		{
			ballRigidbody2D.AddForce(direction, ForceMode2D.Force);
		}

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			ballRigidbody2D.AddForce(-direction, ForceMode2D.Force);
		}

		if (Input.GetKey(KeyCode.UpArrow))
		{
			ballRigidbody2D.AddForce(yDirection);
		}
	}
}	