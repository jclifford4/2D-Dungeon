using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }
    private string ActiveSceneName;
    private int ActiveSceneNum;
    

    // Singleton Pattern
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this);

            ActiveSceneName = getActiveSceneName();
            ActiveSceneNum = getActiveSceneNum();



            Debug.Log("Scene Instance: " + Instance);
        }
        else
        {
            Destroy(gameObject);

        }
    }

    public int getActiveSceneNum()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }

    public string getActiveSceneName()
    {
        return SceneManager.GetActiveScene().name;
    }

    public bool canPressQuitButton { get; set; }


}
