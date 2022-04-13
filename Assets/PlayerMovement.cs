using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private const float walkSpeed = 5f;
    [SerializeField] private const float sprintSpeed = 8f;
    [SerializeField] private float currentSpeed = walkSpeed;
    [SerializeField] private bool isSprinting = false;
    [SerializeField] private bool isGrounded;
    private Rigidbody2D body;

    


    private void Awake()
    {
        body = GameObject.Find("Player_Obj").GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        
    }

    private void Update()
    {

        body.velocity = new Vector2(Input.GetAxis("Horizontal") * currentSpeed, body.velocity.y);


        if (Input.GetKeyDown(KeyCode.LeftShift) && isGrounded)
        {
            isSprinting = true;

            currentSpeed = sprintSpeed;
            body.velocity = new Vector2(currentSpeed, body.velocity.y);

        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isSprinting = false;
            currentSpeed = walkSpeed;
            body.velocity = new Vector2(currentSpeed, body.velocity.y);

        }


        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            body.velocity = new Vector2(body.velocity.x, walkSpeed);
        }


        


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Terrain"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Terrain")) 
        {
            isGrounded = false;
        }
    }
}
