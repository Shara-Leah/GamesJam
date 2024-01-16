using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boulderManager : MonoBehaviour
{
    //Where boulder resets to on x axis
    public int resetPositionX = 40;

    //On trigger, boulder teleports to (40, random y). 
    public void OnTriggerEnter2D (Collider2D col)
    {
        col.transform.position = new Vector2(resetPositionX, Random.Range(-10.0f, 10.0f));
    }    
}
