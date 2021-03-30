using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerBehaviour : MonoBehaviour
{
   public UnityEvent triggerEnterEvent;

   private void OnTriggerEnter(Collider other)
   {
      triggerEnterEvent.Invoke();
   }
}
