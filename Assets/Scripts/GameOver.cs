using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    public static bool isGameOver = false;
    public GameObject gameOverUI;

    void Awake() {
        
        gameOverUI.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        // Debug.Log("menu: " + PlayerController.isCharacterDie);   
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
