using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovementxy : MonoBehaviour
{

    Vector3 movement;
    Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        Move(h);
    }

    void Move(float h) //The movement method for the player
    {
        movement.Set(h, 0f, 0f);

        movement = movement.normalized * 10f * Time.deltaTime;
        rb.MovePosition(transform.position + movement); //Actually move the player relative to its current position
    }

}


//public class playerMovement : MonoBehaviour
//{

//    Vector3 movement;
//    Rigidbody rb;

//    // Use this for initialization
//    void Start()
//    {
//        rb = GetComponent<Rigidbody>();
//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }

//    void FixedUpdate()
//    {
//        float h = Input.GetAxisRaw("Horizontal");
//        Move(h);
//    }

//    void Move(float h) //The movement method for the player
//    {
//        movement.Set(h, 0f, 0f);

//        movement = movement.normalized * 10f * Time.deltaTime;

//        rb.MovePosition(transform.position + movement); //Actually move the player relative to its current position
//    }

//}