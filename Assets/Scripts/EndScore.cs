using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class EndScore : MonoBehaviour
{
    public TextMeshProUGUI endScoreText;

    void Awake() {
        endScoreText = GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {        
        endScoreText.text = "Score: " + Score.score;
    }
}
