using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Setting : MonoBehaviour
{

    public void turnOffSound() {
        PlayerPrefs.SetInt("MutePrefs", 1);
    }

    public void turnOnSound() {
        PlayerPrefs.SetInt("MutePrefs", 0);
    }
}
