using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float horsePower = 0f;
   private const float turnSpeed = 40f;
    private float horizontalInput;
    private float forwardInput;

    private Rigidbody playerRb;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Forward/reverse movement control and turn control
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        playerRb.AddRelativeForce(Vector3.forward * horsePower * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
