using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsBehaviour : MonoBehaviour
{
    private float tobBound = 40;
    private float lowerBound = -10;
    void Update()
    {
        if (transform.position.z > tobBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
