using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HandlerGame : MonoBehaviour
{

    public static bool isGameOver = false;
    public GameObject gameOverUI;

    void Awake() {
        
        gameOverUI.SetActive(false);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.M) && !isGameOver){
            SceneManager.LoadScene("Scenes/Menu");
        }

        if(isGameOver) {
            Over();
        }
        else{
            notOver();
        }
    }
    void notOver() {
        gameOverUI.SetActive(false);
    }

    void Over() {
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;        
    }
}
