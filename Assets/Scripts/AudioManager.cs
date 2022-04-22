using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    private static AudioManager _instance;

   public static AudioManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.Log("AudioManager is Null");
            }

            return _instance;
        }
    }

    public SoundScript[] sounds;
    // Start is called before the first frame update
    void Start()
    {
        Play("Theme");
    }

    private void Awake()
    {

        DontDestroyOnLoad(this);

        if (_instance == null)
        {
            _instance = this;
            

        }
        else
        {

            UnityEngine.Object.Destroy(gameObject);
            
        }

        


        foreach (SoundScript s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play (string name)
    {
        SoundScript s = Array.Find(sounds, sound => sound.name == name);

        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Play();
    }

    

    public void Pause (string name)
    {

        SoundScript s = Array.Find(sounds, sound => sound.name == name);

        if (s != null)
        {
            s.source.Pause();
        }


    }


    public void Stop (string name)
    {
        SoundScript s = Array.Find(sounds, sound => sound.name == name);

        if ( s != null)
        {
            s.source.Stop();
        }
    }


    public void setVolume(string name, float selectedVol)
    {
        SoundScript s = Array.Find(sounds, sound => sound.name == name);
        s.source.volume = (selectedVol / 1000);
    }
    

}
