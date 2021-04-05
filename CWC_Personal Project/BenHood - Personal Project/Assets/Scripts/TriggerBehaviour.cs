using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerBehaviour : MonoBehaviour
{

   private void OnTriggerEnter(Collider other)
   {
      gameObject.SetActive(false);

      if (other.gameObject.name.Equals("Player"))
      {
         Destroy(gameObject);
      }
   }
}
