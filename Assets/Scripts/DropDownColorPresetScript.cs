using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DropDownColorPresetScript : MonoBehaviour
{

    [SerializeField] TMP_Dropdown _color_dropdown, _difficulty_dropdown;
    [SerializeField] TMP_Dropdown[] dropDownList;
    // Start is called before the first frame update

    private void Awake()
    {

        
    }
    void Start()
    {

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
                _color_dropdown.targetGraphic.color = new Color32(24, 133, 23, 255);  // green
                break;
            case 1:

                _color_dropdown.targetGraphic.color = new Color32(161, 83, 166, 255); // purple
                
                break;
            case 2:
                _color_dropdown.targetGraphic.color = new Color32(160, 196, 255, 255);  // blue
                break;
            case 3:
                _color_dropdown.targetGraphic.color = new Color32(255, 173, 173, 255); // pink

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
