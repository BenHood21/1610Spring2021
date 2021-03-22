using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerBehaviour : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 1;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
        
        int animalIndext = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndext], spawnPos, animalPrefabs[animalIndext].transform.rotation);
    }
}
