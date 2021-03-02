using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosRoadBlockMovement : MonoBehaviour
{
    public float min = 0f;
    public float max = 8f;
    public float barrierSpeed = 5f;
    public float barrierPosition;

    public void Start()
    {
        min = transform.position.x - 0;
        max = transform.position.x + 8;
    }

    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * barrierSpeed, max - min) + min, transform.position.y, barrierPosition);
    }
}