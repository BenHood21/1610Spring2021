using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectX : MonoBehaviour
{
    public float destroyTime;
    void Start()
    {
        Destroy(gameObject, destroyTime); // destroy particle after 2 seconds
    }


}
