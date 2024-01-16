using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulders : MonoBehaviour
{
    public float selfdestruct_in = 4; //Might need to change
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
        if (transform.position != endPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPosition, movementSpeed * Time.deltaTime);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (selfdestruct_in != 0)
        {
            Destroy(gameObject, selfdestruct_in);
        }
    }
}

//No idea how to make the spawning random