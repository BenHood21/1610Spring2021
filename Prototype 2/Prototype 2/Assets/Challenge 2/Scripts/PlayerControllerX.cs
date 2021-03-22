using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject [] dogPrefab;
    private float spawnRangeX = 17;
    private float spawnPosZ = 0;
    private float startDelay = 1;
    private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomDog", startDelay, spawnInterval);
    }

    void SpawnRandomDog()
    {
        int animalIndext = Random.Range(0, dogPrefab.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            
            Instantiate(dogPrefab[animalIndext], spawnPos, dogPrefab[animalIndext].transform.rotation);
    }
    
    
}
