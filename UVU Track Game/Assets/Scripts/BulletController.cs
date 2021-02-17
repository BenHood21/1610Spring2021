using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class BulletController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Ground"))
        {
            Debug.Log("Explode");
            gameObject.SetActive(false);
        }

        if (col.gameObject.name.Equals("Credit"))
        {
            Debug.Log("Pass Through");
            gameObject.SetActive(true);
        }
        
        if (col.gameObject.name.Equals("Wheel"))
        {
            Debug.Log("Hit");
            gameObject.SetActive(false);
        }
    }

}
