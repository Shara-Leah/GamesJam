using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    //Grabs the rigidbody of the sprite, which allows it to move the way it should
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    //Tells the player they can only move side to side at a certain speed
    void Update()
    {
        float input = Input.GetAxisRaw("Vertical");
        rb.velocity = new Vector2(input * speed, 0);
    }
}
