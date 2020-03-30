using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Setting : MonoBehaviour
{

    // void Awake() {
    //     PlayerPrefs.SetInt("MutePrefs", 0);
    // }


    public void turnOffSound() {
        PlayerPrefs.SetInt("MutePrefs", 1);
        Debug.Log("mati");
    }

    public void turnOnSound() {
        PlayerPrefs.SetInt("MutePrefs", 0);
        Debug.Log("nyala");
    }
}
