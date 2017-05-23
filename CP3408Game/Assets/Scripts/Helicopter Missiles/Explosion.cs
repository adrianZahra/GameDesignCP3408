using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    private float time;
    public float explosionTime = 1f;
    public float colliderTime = 0.9f;
    private GameObject player;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        time = explosionTime;
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            DestroyImmediate(gameObject);
        }

    }

    void OnTriggerEnter(Collider other) // Because "IsTrigger" is enabled on the sphere collider, this method can be used.
    {
        if (other.gameObject == player)
        {
            // Player is able to walk through ongoing explosion if colliderTime threshold is passed
            if (time >= colliderTime) {
                Debug.Log("Player hit!");
            }
        }
    }
}
