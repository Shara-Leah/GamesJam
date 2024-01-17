using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boulderManager : MonoBehaviour
{
    //Where boulder resets to on x axis
    public int resetPositionX;
    public GameObject boudler;
    private GameObject spawnedBoudler;
    public float boudlerSpeed;
    private Rigidbody2D rb;
    private float spawnPosY;

    //On trigger, boulder is destroyed and a new one is created  
    public void OnTriggerEnter2D (Collider2D other)
    {
        Destroy(other.gameObject);
        GameObject spawnedBoudler = Instantiate(boudler);
        spawnPosY = Random.Range(-6f, 6f); //Picks random Y value to teleport boudler to
        spawnedBoudler.transform.position = new Vector3(resetPositionX, spawnPosY, 0); //Sets position for new boulder
    }    
}
