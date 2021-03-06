﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ApplicationManager : MonoBehaviour
{

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
    }

    public void SetMasterVolume(Slider slider)
    {
        GetComponent<AudioSource>().volume = slider.value;
    }

    public void SetVideoQuality(Slider slider)
    {
        QualitySettings.SetQualityLevel((int)slider.value, true);
    }


    public void LoadScene(string name)
    {
        Application.LoadLevel(name);
    }

    // Use this for initialization
    void Start()
    {
        //audio.Play();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
