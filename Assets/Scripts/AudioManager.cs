﻿using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;

    void Awake()
    {
        if(instance == null) {
            instance = this;
        }
        else{
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        
        foreach (Sound s in sounds) {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;            
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;

            s.source.mute = s.mute;
        }
    }

    void Update() {
        ToggleMute();
    }

    void Start() {
        Play("BGM");
    }

    public void ToggleMute() {
        int isMute = PlayerPrefs.GetInt("MutePrefs");
            if(isMute == 1){
                AudioListener.volume = 0f;                
            }
            else {
                AudioListener.volume = 1f;     
            }
    }
    public void Play(string name) {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if(s == null) {
            Debug.LogWarning("Sound : " + name + " not found!");            
            return;
        }
        s.source.Play();
    }

    public void StopPlaying (string sound)
    {
        Sound s = Array.Find(sounds, item => item.name == sound);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }

        s.source.Stop ();
    }

}
