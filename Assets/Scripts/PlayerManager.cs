using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private static PlayerManager _instance;
    [SerializeField] private int score;
    [SerializeField] private string color, name;
    [SerializeField] private Color colorValue;

    public static PlayerManager Instance
    {
        get
        {
            if (_instance == null)
            {

                //Debug.Log("PlayerManager is Null");
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


    public int getScore()
    {
        return score;
    }

    private void setScore(int score)
    {
        this.score = score;
       
    }

    public void addToScore(int val)
    {
        setScore(getScore() + val);
    }


    public void setName(string name)
    {
        this.name = name;

    }

    public void setColorValue(Color colorValue)
    {
        this.colorValue = colorValue;
    }

    public Color getColorValue()
    {
        return colorValue;
    }

    public void setColor(string color)
    {
        this.color = color;

    }

    public string getColor()
    {
        return color;
    }
}

