using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePropellerRear : MonoBehaviour
{

    public float rotationsPerMinute = 200f;
    void Update()
    {
        transform.Rotate(0, 6.0f * rotationsPerMinute * Time.deltaTime, 0);
    }
}
