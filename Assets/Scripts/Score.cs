using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static int score;

    void Awake() {
        scoreText = GetComponent<TextMeshProUGUI>();
        score = 0;
    }
    void Update()
    {        
        scoreText.text = "Score: " + score;
    }

}
