using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{

    private bool jumped = false;
    private int count = 0;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            FindObjectOfType<AudioManager>().Play("PlayerSteps1");
        }
        else if ((Input.GetKeyUp(KeyCode.A)) || (Input.GetKeyUp(KeyCode.D)) || (!PlayerMovement.isTouchingGround()))
        {
            FindObjectOfType<AudioManager>().Stop("PlayerSteps1");

            /*if (Input.GetKeyDown(KeyCode.Space))
            {
                
                FindObjectOfType<AudioManager>().Play("PlayerJump");
                
            }*/
           
        }


        if (Input.GetKeyDown(KeyCode.Space) && PlayerMovement.getYvelocity() == 0 && PlayerMovement.isTouchingGround())
        {
            FindObjectOfType<AudioManager>().Stop("PlayerSteps1");
            FindObjectOfType<AudioManager>().Play("PlayerJump");

        }else if (((Input.GetKeyDown(KeyCode.Space)) && (Input.GetKeyUp(KeyCode.A)) || Input.GetKeyUp(KeyCode.D)))
        {
            FindObjectOfType<AudioManager>().Stop("PlayerSteps1");
        }
    }
}
