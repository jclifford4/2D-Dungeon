using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneManagerScript : MonoBehaviour
{

    public string ActiveSceneName;
    public int ActiveSceneNum;
    public bool canQuit;
    private Button b_quit;

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
        if (ActiveSceneNum == 0)
        {
            canQuit = true;
            UIManager.Instance.canPressQuitButton = canQuit;

            b_quit = GameObject.Find("Quit_Button").GetComponent<Button>();
            b_quit.onClick.AddListener(() => { QuitGame(); });


        }
        else
        {
            canQuit = false;
            UIManager.Instance.canPressQuitButton = canQuit;
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
