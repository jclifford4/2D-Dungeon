using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    [SerializeField] private int deaths, score;
    [SerializeField] private string difficulty;
    
    

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

        
        updateScore();
        //DeathManager.updateDeaths();
        
    }


    private void updateScore(){

        if ((UIManager.Instance.getActiveSceneNum() > 2) && (UIManager.Instance.getActiveSceneNum() < 5))
        {
            score = PlayerManager.Instance.getScore();
        }
        
    }


    public void setDifficulty(string diff)
    {
        this.difficulty = diff;
    }













}
