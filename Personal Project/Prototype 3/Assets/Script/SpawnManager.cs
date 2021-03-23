using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class SpawnManager : MonoBehaviour
{

    public GameObject obstaclePrefab;

    private Vector3 spawnPos = new Vector3(40, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    
     void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, repeatRate);
    }

     void SpawnObstacle()
     {
         Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
     }
}
