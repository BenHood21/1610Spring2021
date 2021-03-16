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
    public GameObject projectilePrefab, projectilePrefab2;
    
    private Vector3 direction = Vector3.zero;
    
    

    private void Update()
    {
        // Movement
        horizontalInput = Input.GetAxis("Horizontal");
        direction.Set(horizontalInput * speed, 0, 0);
        transform.Translate(direction * Time.deltaTime);

        // Projectile key comand
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        // Movement Boundary
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
