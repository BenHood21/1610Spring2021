using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerController : MonoBehaviour
{ 
    [SerializeField] float speed;
    [SerializeField] private float rpm;
    [SerializeField] float horsePower = 0f;
    [SerializeField] float turnSpeed = 30f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRb;
    
    [SerializeField] private GameObject centerOfMass; 
    [SerializeField] private TextMeshProUGUI speedometerText;
    [SerializeField] private TextMeshProUGUI rpmText;

      [SerializeField] List<WheelCollider> allWheels;
    [SerializeField] int wheelsOnGround;

    
   

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }
    

    // Forward/reverse movement control and turn control
    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        if (IsOnGround())
        {

           
            
            playerRb.AddRelativeForce(Vector3.forward * forwardInput * horsePower);
           
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        
            speed = Mathf.RoundToInt(playerRb.velocity.magnitude * 2.237f);
            speedometerText.SetText("Speed: " + speed + " mph");

          
            rpm = Mathf.Round((speed % 30) * 40);
            rpmText.SetText("RPM: " + rpm);
        }
    }

    bool IsOnGround()
    {
        wheelsOnGround = 0;
        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }
        if (wheelsOnGround == 4)
        {
            return true;
        } else
        {
            return false;
        }
    }
}
