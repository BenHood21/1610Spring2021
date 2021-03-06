using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class DestroyBehaviour : MonoBehaviour
{
    private void Update()
    {
        Destroy(gameObject, 3f);
    }
    //void OnTriggerEnter2D(Collider2D col)

    //if (col.gameObject.name.Equals("Rock"))
      // {
       //     gameObject.SetActive(false);
}