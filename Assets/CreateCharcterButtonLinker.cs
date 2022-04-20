using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class CreateCharcterButtonLinker : MonoBehaviour
{

    [SerializeField] TMP_InputField n_input;
    [SerializeField] Button b_name, b_color, b_diff;
    [SerializeField] TMP_Dropdown d_color, d_diff;
    
    // Start is called before the first frame update
    void Start()
    {


        n_input = GameObject.Find("tmp_name_input").GetComponent<TMP_InputField>();
        n_input.onValueChanged.AddListener(delegate { listen(); });

        d_color = GameObject.Find("tmp_color_drop").GetComponent<TMP_Dropdown>();
        d_color.onValueChanged.AddListener(delegate { listen(); });


        d_diff = GameObject.Find("tmp_difficulty_drop").GetComponent<TMP_Dropdown>();
        d_diff.onValueChanged.AddListener(delegate { listen(); });


        b_name = GameObject.Find("Name_Button").GetComponent<Button>();
        b_name.onClick.AddListener(delegate { saveName(); });


        b_color = GameObject.Find("Color_Button").GetComponent<Button>();
        b_color.onClick.AddListener(delegate { saveColor(); });

        b_diff = GameObject.Find("Difficulty_Button").GetComponent<Button>();
        b_diff.onClick.AddListener(delegate { saveDiff(); });

    }

    private void listen()
    {
        /*if (n_input.text.Length > 0)
        {
            PlayerManager.Instance.setName(n_input.text.ToString());
        }*/

        return;
    }

    private void saveName()
    {
        if (n_input.text.Length > 0)
        {
            PlayerManager.Instance.setName(n_input.text.ToString());
        }
    }

    private void saveDiff()
    {
        GameManager.Instance.setDifficulty(d_diff.options[d_diff.value].text);
    }

    private void saveColor()
    {
        PlayerManager.Instance.setColor(d_color.options[d_color.value].text);
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
