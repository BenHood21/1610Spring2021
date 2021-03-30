using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManagerBehaviour : MonoBehaviour
{
  public GameObject enemyPrefab;
  private float spawnRange = 9;

  private void Start()
  {
    Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);

  }

  private Vector3 GenerateSpawnPosition()
  {
    //Boundraies of Spawn random
    float spawnPosX = Random.Range(-spawnRange, spawnRange);

    float spawnPosZ = Random.Range(-spawnRange, spawnRange);

    Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
    return randomPos;
  }
}
