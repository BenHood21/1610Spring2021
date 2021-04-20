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
    
    
    // Start is called before the first frame update
    void Start()
    {
        min = transform.position.x - posMax;
        max = transform.position.x + posMax;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.PingPong( barrierPosition),
            (Time.time * barrierSpeed, posMax - posMin) + posMin, transform.position.y);

    }
}
