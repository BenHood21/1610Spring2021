using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NegRoadBlockMovement : MonoBehaviour
{
    public float min = -8f;
    public float max = 0f;
    public float barrierSpeed = 10f;
    public float barrierPosition;

    public void Start()
    {
        min = transform.position.x - 8;
        max = transform.position.x + 0;
    }

    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * barrierSpeed, max - min) + min, transform.position.y, barrierPosition);
    }
}