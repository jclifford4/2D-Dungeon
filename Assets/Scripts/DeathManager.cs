using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DeathManager : MonoBehaviour
{
    // Start is called before the first frame update
    TMP_Text txt_death_pts;

    // Start is called before the first frame update
    void Start()
    {

    }
    private void Awake()
    {
        txt_death_pts = GameObject.Find("txt_death_pts").GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (UIManager.Instance.getActiveSceneNum() == 1)
        {

            //txt_death_pts.text = GameManager.Instance.deaths.ToString();





        }
    }

    internal static void updateDeaths()
    {
       if (UIManager.Instance.getActiveSceneNum() == 1 && Input.GetKeyDown(KeyCode.X))
        {
            //GameManager.Instance.deaths++;
        }
    }
}
