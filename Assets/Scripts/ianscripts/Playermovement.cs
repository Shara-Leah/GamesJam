using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float movementSpeed;
    
    //Grabs the rigidbody of the sprite, which allows it to move the way it should
    
  
    //Tells the player they can only move side to side at a certain speed
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("down");
            transform.position += new Vector3(0, movementSpeed * Time.deltaTime, 0);

        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("up");
            transform.position += new Vector3(0, (movementSpeed/-1) * Time.deltaTime, 0);

        }
    }

}

