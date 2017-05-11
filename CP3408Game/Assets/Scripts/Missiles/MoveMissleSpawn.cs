using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMissleSpawn : MonoBehaviour {
    GameObject Player;
    GameObject MissleSpawnPoint;
    float position;

    void Awake()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        MissleSpawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint");
    }

    // Update is called once per frame
    void Update()
    {
        MissleSpawnPoint.transform.position = new Vector3(Player.transform.position.x, 10, Player.transform.position.z); //moves spawn point acodingly to the players position

    }
    // Use this for initialization
    void Start () {
		
	}

}
