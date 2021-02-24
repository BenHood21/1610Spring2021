using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostBehavior : MonoBehaviour
{
   // Movement control
   private Vector3 posOffset = new Vector3();
   private Vector3 temPos = new Vector3();
   
   public float degreePerSecond = 5f;
   public float amplitude = 0.2f;
   public float frequency = .5f;
   
   void Start ()
      //Starting position and rotation of the object
   {
      posOffset = transform.position;
   }

   void Update()
      //Spin credit (dimond) around the Xaxis
   {
      transform.Rotate(new Vector3(0f, 0f, 100f) * Time.deltaTime); 
        
      // Credit Movement vertical
      temPos = posOffset;
      temPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

      transform.position = temPos;
   }
   private void OnTriggerEnter2D(Collider2D other)
   {
      if (other.gameObject.name.Equals("Bullet"))
      {
         gameObject.SetActive(true);   
      }
      // Trigger on BB8
      if (other.gameObject.name.Equals("Wheel"))
      {
         gameObject.SetActive(false);
      }
      
   }
   
}
