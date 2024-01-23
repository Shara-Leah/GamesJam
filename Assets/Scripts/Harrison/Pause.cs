using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public bool gameIsPaused;
    public float speed = 7500;
    public Vector3 target = new Vector3(-8.7f, 24.7f, -7f); //Might need to change (moves a transparent pause menu over the frozen game scene. We could either use this or a scene loader (if player presses escape, switch to pause menu scene)
    //Tells the game and everything in it to stop when the player presses a key and allows the pause menu to move into position
    public void OnButtonPress()
    {
        gameIsPaused = !gameIsPaused;
        PauseGame();
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, target, step);

    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target, step);
        }
       
    }
    //Tells everything to stop moving
    void PauseGame()
    {
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
