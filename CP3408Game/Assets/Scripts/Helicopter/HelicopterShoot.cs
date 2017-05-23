using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelicopterShoot : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 20;
    public float timeBetweenShots = 5f; // Duplicate time variable because timeBetweenShots changes over time 
    private float time;

    private void Start()
    {
        time = timeBetweenShots;
    }
    
    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;

            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            
            projectile.transform.rotation = transform.rotation;

            time = timeBetweenShots;
        }
    }
}
