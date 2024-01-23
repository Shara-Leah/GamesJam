using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulders : MonoBehaviour
{

    public float MovementSpeed = -0.1f;   // base speed
    public float SpeedUp = -0.1f;         // speed up by
    public float MaxSpeed = -0.3f;        // max speed
    public float CurrentSpeed = -0.1f;       // how fast its going
    private bool CanSpeedUp = true;        // can we go faster

    private void Update()
    {
        // limits how fast bolder can go
        if (CurrentSpeed == MaxSpeed)
        {
            CanSpeedUp = false;

        }
        else
        {
            CanSpeedUp = true;
        }
        transform.position = transform.position + new Vector3(CurrentSpeed + MovementSpeed, 0);  // moves bolder

        if (CanSpeedUp == true && Input.GetKey(KeyCode.D)) // Accelerate up to the maximum speed when d is held down
        {
            CurrentSpeed = Mathf.Min(MovementSpeed + SpeedUp);
        }
        else // Decelerate when D is not held down
        {
            CurrentSpeed = Mathf.Max(MovementSpeed - SpeedUp, 0f);
        }
    }
}