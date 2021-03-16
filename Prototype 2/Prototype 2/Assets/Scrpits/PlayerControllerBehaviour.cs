using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerControllerBehaviour : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 50;
    public float xRange = 20;

    private Vector3 direction = Vector3.zero;
    public bool gameOver = false;
    

    private void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");
        direction.Set(horizontalInput * speed, 0, 0);
        transform.Translate(direction * Time.deltaTime);


        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
