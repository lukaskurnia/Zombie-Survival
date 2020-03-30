using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int score;
    // Update is called once per frame

    void Awake() {
        scoreText = GetComponent<TextMeshProUGUI>();
        score = 0;
    }
    void Update()
    {        
        scoreText.text = "Score: " + score;
    }

}
