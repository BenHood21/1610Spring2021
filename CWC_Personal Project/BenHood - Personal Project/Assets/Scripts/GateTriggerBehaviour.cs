using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateTriggerBehaviour : MonoBehaviour
{
    public bool hasKey;
    
    
  private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstecule") && hasKey)
        {
            Debug.Log("Went to door with " + hasKey);
        }
    }
}
