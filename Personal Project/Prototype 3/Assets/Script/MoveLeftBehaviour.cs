using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftBehaviour : MonoBehaviour
{
    private float speed = 10;

    private void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
}
