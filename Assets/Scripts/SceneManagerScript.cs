using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class SceneManagerScript : MonoBehaviour
{

    public string ActiveSceneName;
    public int ActiveSceneNum;
    public bool canQuit;
    private Button b_quit, b_play, b_about;
    public static TMP_Text t_pts;
    // Start is called before the first frame update
    private void Start()
    {
        ActiveSceneName = UIManager.Instance.getActiveSceneName();
        ActiveSceneNum = UIManager.Instance.getActiveSceneNum();
        Debug.Log("Current Scene Name: " + ActiveSceneName +
                "\nCurrent Scene Num: " + ActiveSceneNum);

       
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) QuitGame();

        ActiveSceneName = UIManager.Instance.getActiveSceneName();
        ActiveSceneNum = UIManager.Instance.getActiveSceneNum();

        
    }

    private void Awake()
    {
     
        switch (UIManager.Instance.getActiveSceneNum())
        {
            case 0:
                
                canQuit = true;
                UIManager.Instance.canPressQuitButton = canQuit;

                b_quit = GameObject.Find("Quit_Button").GetComponent<Button>();
                b_quit.onClick.AddListener(() => { QuitGame(); });

                b_play = GameObject.Find("Play_Button").GetComponent<Button>();
                b_play.onClick.AddListener(() => { UIManager.Instance.goToSceneX(1); });

                b_about = GameObject.Find("About_Button").GetComponent<Button>();
                b_about.onClick.AddListener(() => { UIManager.Instance.goToSceneX(2); });

                break;

            case 1:
                
                
                break;

            default:
                canQuit = false;
                UIManager.Instance.canPressQuitButton = canQuit;
                break;
        }
    }

    



    public void QuitGame()
    {

#if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;

#endif
        if (UIManager.Instance.canPressQuitButton == true)
        {
            Application.Quit();
        }
       
    }
}
