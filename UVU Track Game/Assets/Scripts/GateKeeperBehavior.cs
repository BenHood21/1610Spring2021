using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateKeeperBehavior : MonoBehaviour
{
    public BoolData keyObj;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("Bullet"))
        {
            gameObject.SetActive(true);
        }

        // Trigger on BB8
        if (other.gameObject.name.Equals("Wheel"))
        {
            gameObject.SetActive(false);
        }

    }
}
