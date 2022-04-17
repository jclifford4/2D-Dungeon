using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System;

public class UIManager : MonoBehaviour
{
    public static UIManager _instance;
    private string ActiveSceneName;
    private int ActiveSceneNum;

    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {

                Debug.Log("UIManager is Null");
                /*GameObject go = new GameObject("GameManager");
                go.AddComponent<GameManager>();*/

                
            }

            return _instance;
        }
    }

    private void Awake()
    {
        DontDestroyOnLoad(this);
        if (_instance == null)
        {
            _instance = this;
            Debug.Log("UIManager _instance: " + _instance);
            ActiveSceneName = getActiveSceneName();
            ActiveSceneNum = getActiveSceneNum();
        }
        else
        {
            UnityEngine.Object.Destroy(gameObject);
        }
    }

    public void quitGame()
    {
#if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;

#endif
       

        Application.Quit();



    }

    private void Update()
    {
        
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

    public void goToSceneX(int x)
    {
        SceneManager.LoadScene(x);
        //ActiveSceneName = UIManager.Instance.getActiveSceneName();
        //ActiveSceneNum = UIManager.Instance.getActiveSceneNum();
    }


    public void goToMainMenu()
    {
        SceneManager.LoadScene(0);
    }




}
