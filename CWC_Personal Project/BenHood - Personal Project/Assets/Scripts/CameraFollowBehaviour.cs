using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowBehaviour : MonoBehaviour
{
    public GameObject player;
    public float rotationSpeed;
    
    private Vector3 offset = new Vector3(-2, 9, 0);

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
        transform.position = player.transform.position + offset;
    }
}
