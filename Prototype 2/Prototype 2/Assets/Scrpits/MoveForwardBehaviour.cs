using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardBehaviour : MonoBehaviour
{
   public float speed = 40f;
  

   private void Update()
   {
      transform.Translate(Vector3.forward * Time.deltaTime * speed);
   
   }
}
