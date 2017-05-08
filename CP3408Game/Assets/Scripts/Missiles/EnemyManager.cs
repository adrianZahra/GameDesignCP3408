using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    //public PlayerHealth playerHealth;
    //public GameDataClass _gameDataClass;
    public float playerHealthTemp = 10f;
    public int roundNumberTemp = 11;
    public GameObject enemySmall;
    public GameObject enemyMedium;
    public GameObject enemyLarge;
    public float spawnTime = 3f;
    public Transform[] spawnPoints;

    
    void Start()
    {
        InvokeRepeating("SpawnSmallMissle", spawnTime, spawnTime);

        if(roundNumberTemp == 5) // <-- get the number of rounds
        {
            InvokeRepeating("SpawnMediumMissle", spawnTime, spawnTime);
        }

        if(roundNumberTemp == 10)
        {
            InvokeRepeating("SpawnMissle", spawnTime, spawnTime);
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
