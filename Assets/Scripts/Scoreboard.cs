using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    public TextMeshProUGUI player1;
    public TextMeshProUGUI player2;
    public TextMeshProUGUI player3;
    public TextMeshProUGUI player4;
    public TextMeshProUGUI player5;
    public TextMeshProUGUI player6;
    private const string URL = "http://134.209.97.218:5051/scoreboards/13517006";

    public void GetAllScore(){
        WWW request = new WWW(URL);
        StartCoroutine(OnResponse(request));
    }

    string fixJson(string value)
    {
        value = "{\"Items\":" + value + "}";
        return value;
    }

    private IEnumerator OnResponse(WWW req) {
        yield return req;

        if(req != null)
        {
            string jsonString = fixJson(req.text);
            PlayerScore[] playerScores = JsonHelper.FromJson<PlayerScore>(jsonString);

            int limit = 6;
            if(playerScores.Length < 6){
                limit = playerScores.Length;
            }

            for(int i = 0; i < limit; i++) {
                if(i == 0)
                player1.text = playerScores[i].username + "      " + playerScores[i].score;
                if(i == 1)
                player2.text = playerScores[i].username + "      " + playerScores[i].score;
                if(i == 2)
                player3.text = playerScores[i].username + "      " + playerScores[i].score;
                if(i == 3)
                player4.text = playerScores[i].username + "      " + playerScores[i].score;
                if(i == 4)
                player5.text = playerScores[i].username + "      " + playerScores[i].score;
                if(i == 5)
                player6.text = playerScores[i].username + "      " + playerScores[i].score;
            }
        }

    }
}
