using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private static PlayerManager _instance;
    

    public static PlayerManager Instance
    {
        get
        {
            if (_instance == null)
            {

                Debug.Log("PlayerManager is Null");
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
            Debug.Log("PlayerManger _instance: " + _instance);
        }
        else
        {
            Object.Destroy(gameObject);
        }
    }
}

