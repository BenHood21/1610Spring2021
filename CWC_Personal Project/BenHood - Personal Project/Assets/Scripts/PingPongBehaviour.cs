using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongBehaviour : MonoBehaviour
{

    private float min;
    private float max;

    public float barrierSpeed = 10f, barrierPosition;
    public float posMin, posMax;
    
    

    void Start()
    {
        min = transform.position.z - posMax;
        max = transform.position.z + posMax;
    }
    
    void Update()
    {
        transform.position = new Vector3(barrierPosition,  transform.position.y, Mathf.PingPong
            (Time.time * barrierSpeed, posMax - posMin) + posMin);

    }
}
