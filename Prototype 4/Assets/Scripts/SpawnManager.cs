﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9;
    public GameObject powerupPrefab;

    public int enemyCount;
    public int waveNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
       SpawnEnemyWave(waveNumber);
       Instantiate(powerupPrefab,GenerateSpawnPosition(), powerupPrefab.transform.rotation);
    }
//spawns enemies
    void SpawnEnemyWave(int enemyiesToSpawn) {
        for (int i = 0; i < enemyiesToSpawn; i++) {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);  }  }
   
    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0) 
        {
            waveNumber++; 
            SpawnEnemyWave(waveNumber);
            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
        }
    }
//spawn position
    private Vector3 GenerateSpawnPosition ()
        {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        
        return randomPos;
        }
}