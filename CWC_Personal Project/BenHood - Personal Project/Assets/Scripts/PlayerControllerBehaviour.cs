using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerControllerBehaviour : MonoBehaviour
{
  public float speed = 3f, gravity = -8f, jumpForce = 10f;

  private float yDirection;
  private CharacterController controller;
  private Vector3 movement, rotation;

  private void Start()
  {
    controller = GetComponent<CharacterController>();
  }

  private void Update()
  {
    movement.Set(speed * Input.GetAxis("Vertical"), yDirection, 0);

    yDirection += gravity * Time.deltaTime;

    if (controller.isGrounded && movement.y < 0)
    {
      yDirection = -1f;
    }

    rotation.y = Input.GetAxis("Horizontal");
    transform.Rotate(rotation);
    movement = transform.TransformDirection(movement);
    controller.Move(movement * Time.deltaTime);
  }
}
