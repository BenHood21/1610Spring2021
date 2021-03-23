using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Anthony's Jump Code
public class PlayerControllerBehaviour : MonoBehaviour
{
   public float speed = 3f;
   public float jumpForce = 20f;
   public int jumpCountMax = 2;
   public float gravityModifier;


   private int jumpCount;
   private Rigidbody rigidbodyObj;
   private Vector3 direction;
   
   private void Start()
   {
      rigidbodyObj = GetComponent<Rigidbody>();
      Physics.gravity *= gravityModifier;
   }

   private void OnCollisionEnter(Collision other)
   {
      jumpCount = 0;
   }

   private void Update()
   {
      direction.x = speed * Input.GetAxis("Horizontal");
      rigidbodyObj.AddForce(direction, ForceMode.Force);

      if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
      {
         direction.y = jumpForce;
         rigidbodyObj.AddForce(direction, ForceMode.Impulse);
         jumpCount++;
      }
   }
}
