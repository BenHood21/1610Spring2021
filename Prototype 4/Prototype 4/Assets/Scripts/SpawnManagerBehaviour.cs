using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnManagerBehaviour : MonoBehaviour
{
  public GameObject enemyPrefab;
  public GameObject powerupPrefab;
  public int enemyCount;
  public int waveNumber = 1;
  
  private float spawnRange = 9;

   void Start()
  {
      SpawnEnemyWave(waveNumber);
      Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);

  }

   void Update()
  {
      enemyCount = FindObjectsOfType<EnemyBehaviour>().Length;
     
      if (enemyCount == 0)
      {
          waveNumber++;
          SpawnEnemyWave(waveNumber);
          Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
      }
  }

  void SpawnEnemyWave(int enemiesToSpawn)
  {
      for (int i = 0; i < enemiesToSpawn; i++)
      {
          Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
      }
  }
      
  private Vector3 GenerateSpawnPosition()
  {
    //Boundraies of Spawn random
    float spawnPosX = Random.Range(-spawnRange, spawnRange);

    float spawnPosZ = Random.Range(-spawnRange, spawnRange);

    Vector3 randomPos = new Vector3(spawnPosX, 0.5f, spawnPosZ);
    return randomPos;
  }
}
