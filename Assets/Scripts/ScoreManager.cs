using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreManager : MonoBehaviour
{
    TMP_Text txt_pts;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }
    private void Awake()
    {
        txt_pts = GameObject.Find("txt_pts").GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (UIManager.Instance.getActiveSceneNum() == 1)
        {

            //txt_pts.text = GameManager.Instance.score.ToString();

            



        }
    }

    // internal static void updateScore()
    // {
    //     if (UIManager.Instance.getActiveSceneNum() == 1 && GameManager.Instance.score < 9913)
    //     {
    //         //GameManager.Instance.score++;

            

    //     }
    //     else if (UIManager.Instance.getActiveSceneNum() == 1 && 
    //                 (GameManager.Instance.score == 9913))
    //     {

    //         //UIManager.Instance.goToSceneX(0);


    //     }
    // }
}
