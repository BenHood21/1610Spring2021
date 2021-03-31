using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupRotateBehaviour : MonoBehaviour
{

    public float amplitude;
    public float frequency;

  //  private Vector3 posOffset = new Vector3();
  //  private Vector3 temPos = new Vector3();
    
    private void Start()
    {
     // posOffset = transform.position;
    }

    void Update()
    {
        transform.Rotate(new Vector3(0f,0.5f,0f));

    // temPos = posOffset;
      //temPos.y = Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

    //  transform.position = temPos;
    }
}
