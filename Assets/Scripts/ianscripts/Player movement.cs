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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space key was pressed");
            transform.position += transform.position + new Vector3(0, movementSpeed * Time.deltaTime, 0);

        }
    }

}

