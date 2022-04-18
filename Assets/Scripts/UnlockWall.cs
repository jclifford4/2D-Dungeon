using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockWall : MonoBehaviour
{

    [SerializeField] GameObject locked_wall;
    Vector3 startPos;
    // Start is called before the first frame update
    void Start()
    {
        locked_wall = GameObject.FindGameObjectWithTag("LockedWall");
        startPos = locked_wall.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    /*private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            //lowerWall();
        }
    }*/


    private void OnCollisionStay2D(Collision2D collision)
    {
        if((PlayerManager.Instance.getScore() > 15) && (collision.gameObject.CompareTag("Player"))){

            Debug.Log("Touching LockedWall");

            raiseWall();
            //Destroy(locked_wall);
            
        }

      
    }

    private void raiseWall()
    {
        locked_wall.transform.position = Vector3.MoveTowards(locked_wall.transform.position, new Vector3(locked_wall.transform.position.x, locked_wall.transform.position.y + 10.0f,
                                        locked_wall.transform.position.z), 2 * Time.deltaTime);
    }


    /*private void lowerWall()
    {
        locked_wall.transform.position = Vector3.MoveTowards(locked_wall.transform.position, new Vector3(startPos.x, startPos.y,
                                        startPos.z), .25f * Time.deltaTime);
    }*/

    /*private bool checkWallKeyPress()
    {
        if (Input.GetKeyDown(KeyCode.E)) return true;

        return false;
    }*/
}
