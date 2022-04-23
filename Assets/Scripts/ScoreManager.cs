using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ScoreManager : MonoBehaviour
{
    TMP_Text txt_pts;
    [SerializeField] private  TMP_Text txt_time_value, txt_time;
    [SerializeField] private static TMP_Text sTxt_time, s_text_time_value;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        txt_pts = GameObject.Find("txt_pts").GetComponent<TMP_Text>();
        txt_time_value = GameObject.Find("txt_time_value").GetComponent<TMP_Text>();

        txt_time = GameObject.Find("txt_time").GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (UIManager.Instance.getActiveSceneNum() > 2 && UIManager.Instance.getActiveSceneNum() < 6)
        {
            s_text_time_value = txt_time_value;
            sTxt_time = txt_time;
            txt_pts.text = PlayerManager.Instance.getScore().ToString();
            /*int time = (int)LevelTimer.getLvlTime();*/
            txt_time_value.text = Mathf.Round(LevelTimer.getLvlTime()).ToString();

        }

        
    }


    internal static TMP_Text getTimeTxt()
    {
        return sTxt_time;
    }

    internal static TMP_Text getTimeValue()
    {
        return s_text_time_value;
    }




}
