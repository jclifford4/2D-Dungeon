using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTimer : MonoBehaviour
{
    [SerializeField] private static float targetTime = 120.0f, startTime;
    [SerializeField] private float timescale = .5f;
    private TMPro.TMP_Text txt_time;

    private void Start()
    {
        
        if (GameManager.Instance.getDifficulty() == "Easy")
        {
            targetTime = 240.0f;
            
        }
        else if (GameManager.Instance.getDifficulty() == "Medium")
        {
            targetTime = 180.0f;
            
        }else if (GameManager.Instance.getDifficulty() == "Hard")
        {
            targetTime = 90.0f;
            
        }
        else
        {
            targetTime = 240.0f;
            
        }

        startTime = targetTime;
    }

    void Update()
    {
        if (UIManager.Instance.getActiveSceneNum() == 3)
        {
            targetTime -= Time.smoothDeltaTime * timescale;
        }
        else
        {
            timescale = 1.0f;
            targetTime -= Time.smoothDeltaTime * timescale;
        }
            


        if (targetTime > 0 &&  targetTime <= startTime/3)
        {
            timerColorRed();
        }
        else if (targetTime <= 0.0f)
        {
            timerEnded();
        }

    }

    private void timerColorRed()
    {
        ScoreManager.getTimeTxt().color = Color.red;
        ScoreManager.getTimeValue().color = Color.red;
    }

    void timerEnded()
    {
        UIManager.Instance.goToSceneX(UIManager.Instance.getActiveSceneNum());
    }

    public static  float getLvlTime()
    {
        return targetTime;
    }
}
