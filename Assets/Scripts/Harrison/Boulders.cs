using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulders : MonoBehaviour
{

    public float movementSpeed = 8; //Can change if we need to
    private Rigidbody rb;
    private Vector3 startPosition = new Vector3(-8, -4, 0); //Will need to change
    private Vector3 endPosition = new Vector3(-8, -4, 0); //Will need to change
    //Grabs the rigidbody of the boulder, which allows it to move
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    //Tells the boulders to move upwards to a specific coordinate at a certain speed
    private void Update()
    {
        transform.position = transform.position + new Vector3( movementSpeed * Time.deltaTime,0);

    }
}