using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerControllerBehaviour : MonoBehaviour
{
  public float speed = 3f, gravity = -8f, jumpForce = 10f;
  private float posZBound = 24, negZBound = -24, posXBound = 24, negXBound = -24;

  private float yDirection;
  private CharacterController controller;
  private Vector3 movement, rotation, startPos;
  public GameObject characterAniamtion;

  private void Start()
  {
    startPos = transform.position;
    controller = GetComponent<CharacterController>();
  }

  private void Update()
  {
    movement.Set(speed * Input.GetAxis("Vertical"), yDirection, 0);

    yDirection += gravity * Time.deltaTime;
    rotation.y = Input.GetAxis("Horizontal");
    transform.Rotate(rotation);
    movement = transform.TransformDirection(movement);
    controller.Move(movement * Time.deltaTime);

    if (controller.isGrounded && movement.y < 0)
    {
      yDirection = -1f;
    }

    if (transform.position.z > posZBound || transform.position.x > posXBound)
    {
      
    }
    else if (transform.position.z < negZBound || transform.position.z < negXBound)
    {
      
    }

    if (Input.GetButtonDown("Vertical"))
    {
      characterAniamtion.GetComponent<Animator>().Play("Walk_Static");
    }

    if (Input.GetButtonUp("Vertical"))
      {
        characterAniamtion.GetComponent<Animator>().Play("Idle");
      }
  }
}