using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5f;

    public Rigidbody2D rb;
  
    // Bullet movement
    void Start()
    {
        rb.velocity = (-transform.up * speed);
    }
}
