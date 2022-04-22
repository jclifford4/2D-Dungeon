using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    [SerializeField] private int deaths, score;
    [SerializeField] private string difficulty;
    [SerializeField] private float lvlTime;
    
    

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                
                Debug.Log("GameManager is Null");
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
            Debug.Log("GameManager _instance: " + _instance);
        }
        else
        {
            Object.Destroy(gameObject);
        }
    }

    private void Update()
    {

        updateLvlTimer();
        updateScore();
        //DeathManager.updateDeaths();
        
        
    }


    private void updateScore(){

        if ((UIManager.Instance.getActiveSceneNum() > 2) && (UIManager.Instance.getActiveSceneNum() < 5))
        {
            score = PlayerManager.Instance.getScore();
        }



        
    }

    public void updateLvlTimer()
    {
        this.lvlTime = LevelTimer.getLvlTime();
    }

    public float getLvlTime()
    {
        return lvlTime;
    }


    public void setDifficulty(string diff)
    {
        this.difficulty = diff;
    }

    public string getDifficulty()
    {
        return difficulty;
    }















}
