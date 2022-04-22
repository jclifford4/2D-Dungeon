using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreManager : MonoBehaviour
{
    TMP_Text txt_pts;
    [SerializeField] TMP_Text txt_time_value;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        txt_pts = GameObject.Find("txt_pts").GetComponent<TMP_Text>();
        txt_time_value = GameObject.Find("txt_time_value").GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (UIManager.Instance.getActiveSceneNum() > 2 && UIManager.Instance.getActiveSceneNum() < 6)
        {

            txt_pts.text = PlayerManager.Instance.getScore().ToString();
            /*int time = (int)LevelTimer.getLvlTime();*/
            txt_time_value.text = Mathf.Round(LevelTimer.getLvlTime()).ToString();

        }

        





    }

    
}
