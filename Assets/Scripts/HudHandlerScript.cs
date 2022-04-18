using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HudHandlerScript : MonoBehaviour
{

    [SerializeField] TMP_Text txt_pts;
    [SerializeField] TMP_Text[] txtList;
    // Start is called before the first frame update
    void Start()
    {
        retreiveTextRef();

        foreach (TMP_Text t in txtList)
        {
            TMP_Text s = t;
             referenceText(s);
            
            
        }

    }

    private void retreiveTextRef()
    {
        
        txtList = GameObject.FindObjectsOfType<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        updatePts();
    }


    private void referenceText(TMP_Text t)
    {
        Debug.Log(t.name);
        if (t.name.Equals("txt_pts"))
        {

            txt_pts = t;
            
            
        }
    }

    private void updatePts()
    {
        txt_pts.text = PlayerManager.Instance.getScore().ToString();
    }
}
