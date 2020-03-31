using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame() {
        HandlerGame.isGameOver = false;
        Time.timeScale = 1f;   
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void QuitGame() {
        Debug.Log("You're quitting this game");
        Application.Quit();
    }
}

