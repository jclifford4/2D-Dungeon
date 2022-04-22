using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTimer : MonoBehaviour
{
    [SerializeField] private static float targetTime = 120.0f;
    [SerializeField] private float timescale = .5f;

    private void Start()
    {
        
        if (GameManager.Instance.getDifficulty() == "easy")
        {
            targetTime = 180.0f;
        }
        else if (GameManager.Instance.getDifficulty() == "medium")
        {
            targetTime = 120.0f;
        }else
        {
            targetTime = 60.0f;
        }
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
            

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

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
