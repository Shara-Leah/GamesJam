using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    //Loads the next scene when the player clicks the play button in the menu scene
    public void PlayGame()
    {
        SceneManager.LoadScene("GamePlay");
    }
    //Allows the player to quit the game when they click the exit button
    public void QuitGame()
    {
        Debug.Log("Exit");
        Application.Quit();
    }

    public void Settings()
    {
        //this scene allows the scenes to swap from the pause menu to the main menu without interuption
        SceneManager.LoadScene("Menu");
    }

    public void Retry()
    {
        //allows the player to retry the game
        SceneManager.LoadScene("GamePlay");
    }

    public void Exit()
    {
        //this scene allows the exit to go and goes to the main menu
        SceneManager.LoadScene("Menu");
    }

    //Above script is for button UIs on click, which could be used for menu and below script could be used for game over screen if player hits boulder

    public AudioSource soundPlayer;
    //Allows the player to move on if they collect the green gem with a sound effect too
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Level progression") //Change variable name
        {
            soundPlayer.Play();
            //SceneManager.LoadScene("Cutscene"); - remove slashes if variable is added
        }
    }
}
