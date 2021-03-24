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
   public bool gameOver = false;
   public bool isOnGround = true;


   private int jumpCount;
   private Rigidbody rigidbodyObj;
   private Vector3 direction;
   private Animator playerAnim;
   
   private void Start()
   {
      rigidbodyObj = GetComponent<Rigidbody>();
      playerAnim = GetComponent<Animator>();
      Physics.gravity *= gravityModifier;
   }

   private void OnCollisionEnter(Collision other)
   {
      jumpCount = 0;

      if (other.gameObject.CompareTag("Ground"))
      {
         isOnGround = true;
      }
      else if (other.gameObject.CompareTag("Obstacle"))
      {
         gameOver = true;
         Debug.Log("Game Over!");
         playerAnim.SetBool("Death_b", true);
         playerAnim.SetInteger("DeathType_int", 1);
      }
   }

   private void Update()
   {
      direction.x = speed * Input.GetAxis("Horizontal");
      rigidbodyObj.AddForce(direction, ForceMode.Force);

      if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax && !gameOver)
      {
         direction.y = jumpForce;
         rigidbodyObj.AddForce(direction, ForceMode.Impulse);
         jumpCount++;
         playerAnim.SetTrigger("Jump_trig");
      }
   }
   
}
