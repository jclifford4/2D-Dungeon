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
        if (UIManager.Instance.getActiveSceneNum() == 3)
        {

            txt_pts.text = PlayerManager.Instance.getScore().ToString();

            



        }
    }

    
}
