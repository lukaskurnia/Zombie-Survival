using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Submit : MonoBehaviour
{
    public TMP_InputField inputText;
    private int myScore;
    private const string URL = "http://134.209.97.218:5051/scoreboards/13517006";

    public void SubmitScore() {           

        myScore = Score.score;    
        WWWForm form  = new WWWForm();

        form.AddField("username", inputText.text);
        form.AddField("score", myScore.ToString());
        byte[] rawFormData = form.data;

        WWW request = new WWW(URL, rawFormData);
        StartCoroutine(OnResponse(request));

    }
    private IEnumerator OnResponse(WWW req) {
        yield return req;

        FindObjectOfType<AudioManager>().StopPlaying("GameOver");
        FindObjectOfType<AudioManager>().Play("BGM");  
        SceneManager.LoadScene("Scenes/Menu");
    }


}
