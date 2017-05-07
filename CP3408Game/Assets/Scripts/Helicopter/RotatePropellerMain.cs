using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropellerMain : MonoBehaviour {

    public float rotationsPerMinute = 200f;
    void Update()
    {
        transform.Rotate(0, 0, 6.0f * rotationsPerMinute * Time.deltaTime);
    }
}
