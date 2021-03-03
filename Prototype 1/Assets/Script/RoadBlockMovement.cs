using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadBlockMovement : MonoBehaviour
{
    private float min;
    private float max;
    public float barrierSpeed = 10f;
    public float barrierPosition;
    public float posMin, posMax;
    
    public void Start()
    {
        min = transform.position.x - posMin;
        max = transform.position.x + posMax;
    }

    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * barrierSpeed, posMax - posMin) + posMin, transform.position.y, barrierPosition);
    }
}