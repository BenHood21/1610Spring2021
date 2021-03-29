using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerBehaviour : MonoBehaviour
{
  private Rigidbody playerRb;
  private GameObject focalPoint;
  
  public float speed = 5f;

  private void Start()
  {
    playerRb = GetComponent<Rigidbody>();
    focalPoint = GameObject.Find("Focal Point");
  }

  private void Update()
  {
    float forwardInput = Input.GetAxis("Vertical");
    playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
  }
}
