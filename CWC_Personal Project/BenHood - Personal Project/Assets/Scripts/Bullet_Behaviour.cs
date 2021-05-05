using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Behaviour : MonoBehaviour
{
   public float speed = 5f;
   public Rigidbody rb;

   private void Start()
   {
      rb.velocity = (transform.up * speed);
   }
}
