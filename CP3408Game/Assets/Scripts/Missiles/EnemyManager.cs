using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //public PlayerHealth playerHealth;
    //public GameDataClass _gameDataClass;
    float playerHealthTemp = 5f;
    int roundNumberTemp = 10;
    public GameObject enemySmall;
    public GameObject enemyMedium;
    public GameObject enemyLarge;
    float smallSpawnTime = 1f;
    float mediumSpawnTime = 5f;
    float largeSpawnTime = 9f;
    public Transform[] spawnPoints;

    
    void Start()
    {
        InvokeRepeating("SpawnSmallMissle", smallSpawnTime, smallSpawnTime);

        if(roundNumberTemp >= 5 && roundNumberTemp < 10) // <-- get the number of rounds
        {
            InvokeRepeating("SpawnMediumMissle", mediumSpawnTime, mediumSpawnTime);
        }
        else if(roundNumberTemp >= 10)
        {
            InvokeRepeating("SpawnMediumMissle", mediumSpawnTime, mediumSpawnTime);
            InvokeRepeating("SpawnLargeMissle", largeSpawnTime, largeSpawnTime);
        }

    }


    void SpawnSmallMissle()
    {
        if (playerHealthTemp <= 0f) // <-- find the players health
        {
            return;
        }

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(enemySmall, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }

    
    void SpawnMediumMissle()
    {
        if (playerHealthTemp <= 0f) 
        {
            return;
        }

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(enemyMedium, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }


    void SpawnLargeMissle()
    {
        if (playerHealthTemp <= 0f) 
        {
            return;
        }

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        Instantiate(enemyLarge, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
  
}
