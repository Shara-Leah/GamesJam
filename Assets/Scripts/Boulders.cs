using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulders : MonoBehaviour
{

    public float movementSpeed = 8; //Can change if we need to
    //Tells the boulders to move at a certain speed
    private void Update()
    {
        transform.position = transform.position + new Vector3( movementSpeed * Time.deltaTime,0);

    }
}