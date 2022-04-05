using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    public void QuitGame()
    {
#if UNITY_EDITOR

        UnityEditor.EditorApplication.isPlaying = false;

#endif
        /*if (UnityEditor.EditorApplication.isPlaying)
        {
            UnityEditor.EditorApplication.isPlaying = false;
            Debug.Log("Quitting!");
        }*/

        Application.Quit();



    }

    private void Update()
    {
        /*if (Input.GetKey("escape")){
            Application.Quit();
        }*/
    }
}
