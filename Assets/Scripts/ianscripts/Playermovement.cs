using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playermovement : MonoBehaviour
{
    public float movementSpeed;

    //Grabs the rigidbody of the sprite, which allows it to move the way it should


    //Tells the player they can only move side to side at a certain speed
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("down");
            transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("up");
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
            Debug.Log("test");
            SceneManager.LoadScene("Game Over");
    }
}



