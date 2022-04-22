using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DropDownColorPresetScript : MonoBehaviour
{

    [SerializeField] TMP_Dropdown _color_dropdown, _difficulty_dropdown;
    [SerializeField] TMP_Dropdown[] dropDownList;

    [SerializeField] private Color green, purple, pink, blue, hardRed, medYellow, easyGreen;
    // Start is called before the first frame update

    private void Awake()
    {

        
    }
    void Start()
    {
        blue = new Color32(160, 196, 255, 255);
        green = new Color32(24, 133, 23, 255);
        purple = new Color32(161, 83, 166, 255);
        pink = new Color32(255, 173, 173, 255);
        hardRed = new Color32(234, 0, 0, 255);
        medYellow = new Color32(246, 226, 0, 255);
        easyGreen = new Color32(45, 212, 25, 255);

        retrieveDropDownRef();
        foreach (TMP_Dropdown drop in dropDownList)
        {
            TMP_Dropdown d = drop;
            referenceDropDowns(d);
            
        }


    }

    private void updateOptionColors()
    {




        switch (_color_dropdown.value)
        {
            case 0:
                _color_dropdown.targetGraphic.color = green; // green
                PlayerManager.Instance.setColorValue(green);
                break;
            case 1:

                _color_dropdown.targetGraphic.color = purple; // 
                PlayerManager.Instance.setColorValue(purple);

                break;
            case 2:
                _color_dropdown.targetGraphic.color = blue;  // blue
                PlayerManager.Instance.setColorValue(blue);
                break;
            case 3:
                _color_dropdown.targetGraphic.color = pink; // pink
                PlayerManager.Instance.setColorValue(pink);

                break;
            default:
                break;
        }

    }


    private void updateDifficultyColorsDropdown()
    {

        switch (_difficulty_dropdown.value)
        {
            case 0:
                _difficulty_dropdown.targetGraphic.color = easyGreen; // green
                
                break;
            case 1:

                _difficulty_dropdown.targetGraphic.color = medYellow; // 
                

                break;
            case 2:
                _difficulty_dropdown.targetGraphic.color = hardRed;  // blue

                break;
            default:
                break;
        }
    }
        

    private void retrieveDropDownRef()
    {
        dropDownList = GameObject.FindObjectsOfType<TMP_Dropdown>();
    }



    void Update()
    {
        updateOptionColors();
        updateDifficultyColorsDropdown();
    }

    private void referenceDropDowns(TMP_Dropdown d)
    {
        if (d.name.Equals("tmp_color_drop"))
        {
            _color_dropdown = d;

            d.ClearOptions();
            List<TMP_Dropdown.OptionData> colors = new List<TMP_Dropdown.OptionData>(5);
            TMP_Dropdown.OptionData green = new TMP_Dropdown.OptionData("Green");
            TMP_Dropdown.OptionData purple = new TMP_Dropdown.OptionData("Purple");
            TMP_Dropdown.OptionData blue = new TMP_Dropdown.OptionData("Blue");
            TMP_Dropdown.OptionData pink = new TMP_Dropdown.OptionData("Pink");
            colors.Add(green);
            colors.Add(purple);
            colors.Add(blue);
            colors.Add(pink);
            
            //d.image.color = Color.green;
            d.AddOptions(colors);

            //d.targetGraphic.color = Color.green;
            
            
            
        }
        else if (d.name.Equals("tmp_difficulty_drop"))
        {
            _difficulty_dropdown = d;

            d.ClearOptions();
            List<TMP_Dropdown.OptionData> difficulty = new List<TMP_Dropdown.OptionData>(5);
            TMP_Dropdown.OptionData easy = new TMP_Dropdown.OptionData("Easy");
            TMP_Dropdown.OptionData medium = new TMP_Dropdown.OptionData("Medium");
            TMP_Dropdown.OptionData hard = new TMP_Dropdown.OptionData("Hard");
            
            difficulty.Add(easy);
            difficulty.Add(medium);
            difficulty.Add(hard);
            

            //d.image.color = Color.green;
            d.AddOptions(difficulty);
        }
    }

    // Update is called once per frame
    
}
