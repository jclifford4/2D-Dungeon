using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickHandler : MonoBehaviour
{

    [SerializeField] private Button b_quit, b_play, b_about, b_create, b_back, b_credits, b_volume;
    [SerializeField] private Button[] buttonList;
    // Start is called before the first frame update
    void Start()
    {
        retrieveButtonRef();

        foreach (Button a in buttonList)
        {
            //Button b = GetComponent<Button>();
            a.onClick.AddListener(() => referenceButton(a));
        }
        // ...

    }


    private void referenceButton(Button a)
    {

        Debug.Log("Button " + a.gameObject.name + " Pressed");

        if (a.gameObject.name == "Quit_Button")
        {
            FindObjectOfType<AudioManager>().Play("ButtonClick");
            UIManager.Instance.quitGame();
        }
        else if(a.gameObject.name == "About_Button")
        {
            FindObjectOfType<AudioManager>().Play("ButtonClick");
            UIManager.Instance.goToSceneX(2);
        }
        else if(a.gameObject.name == "Play_Button")
        {
            FindObjectOfType<AudioManager>().Play("ButtonClick");
            UIManager.Instance.goToSceneX(3);
        }
        else if(a.gameObject.name == "Create_Button")
        {
            FindObjectOfType<AudioManager>().Play("ButtonClick");
            UIManager.Instance.goToSceneX(1);
        }
        else if(a.gameObject.name == "Back_Button")
        {
            FindObjectOfType<AudioManager>().Play("ButtonClick");
            UIManager.Instance.goToMainMenu();
        }
        else if (a.gameObject.name == "Credits_Button")
        {
            FindObjectOfType<AudioManager>().Play("ButtonClick");
            UIManager.Instance.goToSceneX(6);
        }
        else if (a.gameObject.name == "Volume_Button_mus")
        {
            //FindObjectOfType<AudioManager>().Play("ButtonClick");
            FindObjectOfType<AudioManager>().setVolume("Theme", VolumeSliderScript.getMusVolume());
        }
        else if (a.gameObject.name == "Volume_Button_sfx")
        {
            //FindObjectOfType<AudioManager>().Play("ButtonClick");
            FindObjectOfType<AudioManager>().setVolume("PlayerSteps1", VolumeSliderScript.getSFXVolume());
            FindObjectOfType<AudioManager>().setVolume("PlayerJump", VolumeSliderScript.getSFXVolume());
            FindObjectOfType<AudioManager>().setVolume("ItemPickup", VolumeSliderScript.getSFXVolume());

            FindObjectOfType<AudioManager>().Play("ItemPickup");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TaskOnClick(int buttonIndex)
    {
        Debug.Log("You have clicked the button #" + buttonIndex, buttonList[buttonIndex]);
    }



    private void retrieveButtonRef()
    {
        buttonList = GameObject.FindObjectsOfType<Button>();
    }
}
