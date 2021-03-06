using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    
    // Start is called before the first frame update
    public Transform player;
    [SerializeField] private const float walkSpeed = 6f;
    [SerializeField] private const float sprintSpeed = 8f;
    [SerializeField] private const float jumpPower = 6f;
    [SerializeField] private float currentSpeed = walkSpeed;
    [SerializeField] private bool isSprinting = false;
    [SerializeField] private bool isWalking = false;
    [SerializeField] static bool isGrounded;
    [SerializeField] private bool isFacingRight;
    [SerializeField] static int velocityX, velocityY;

    [SerializeField] private bool isIdle;
    private Rigidbody2D body;
    //[SerializeField] SpriteRenderer sr;

    public Animator animator;
    
    


    private void Awake()
    {
        // rigid body of player
        body = GameObject.Find("Player").GetComponent<Rigidbody2D>();
        FindObjectOfType<AudioManager>().Stop("PlayerSteps1");

    }


    // directional facing movement of key press of player sprite.
    private void UpdateSpriteFlip(){

        if (body.velocity.x < 0)
        {
            gameObject.transform.localRotation = Quaternion.Euler(0,180,0);
            
            // gameObject.transform.localScale = new Vector3(-1,1,1);
            isFacingRight = false;
            
        } 
        else if (body.velocity.x > 0) {

            gameObject.transform.localRotation = Quaternion.Euler(0,0,0);
            // gameObject.transform.localScale = new Vector3(1,1,1);
            isFacingRight = true;
            
        }  
        
    }

    private void FixedUpdate()
    {
        //UpdateSpriteFlip();
      
    }

    private void Update()
    {
        

        body.velocity = new Vector2(Input.GetAxis("Horizontal") * currentSpeed, body.velocity.y);
        
        velocityX = (int)body.velocity.x;
        velocityY = (int)body.velocity.y;

        

        



        UpdateSpriteFlip();

        checkSprint();
        
        checkIdle();
        checkJump();


       





    }

    private void checkIdle()
    {
        

        if (!Input.anyKey){
            
               // if (velocityX == 0) FindObjectOfType<AudioManager>().Stop("PlayerSteps1");

            animator.SetTrigger("Idle");
            animator.SetInteger("Speed", 0);
            isIdle = true;
            isSprinting = false;
            isWalking = false;
            

        }
        else{

            
            isIdle = false;

            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)){
                animator.ResetTrigger("Idle");
                animator.SetInteger("Speed", (int) walkSpeed);
                isWalking = true;
                isSprinting = false;
                



            }


            
        }
    }

    private void checkSprint(){
        if (Input.GetKeyDown(KeyCode.LeftShift) && isGrounded)
        {
            isSprinting = true;
            isWalking = false;
            animator.SetTrigger("Idle");
            animator.SetBool("isSprinting", isSprinting);
            
            currentSpeed = sprintSpeed;
            animator.SetInteger("Speed", (int) currentSpeed);
            body.velocity = new Vector2(currentSpeed, body.velocity.y);
            
            

        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            
            isSprinting = false;
            isWalking = true;
            animator.SetBool("isSprinting", isSprinting);
            currentSpeed = walkSpeed;
            animator.SetInteger("Speed", (int) currentSpeed);
            body.velocity = new Vector2(currentSpeed, body.velocity.y);

        }

        

        
    }


    private void checkJump(){
        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded))
        {
            body.velocity = new Vector2(body.velocity.x, jumpPower);
            animator.SetInteger("Speed", 0);
            //FindObjectOfType<AudioManager>().Play("PlayerJump");


        }
        else
        {
            //FindObjectOfType<AudioManager>().Stop("PlayerJump");

        }
            
        
        
    }

    

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Terrain"))
        {
            isGrounded = true;
            animator.SetBool("isGrounded", isGrounded);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Terrain")) 
        {
            isGrounded = false;
            animator.SetBool("isGrounded", isGrounded);
        }
    }


    public static int getYvelocity()
    {
        return velocityY;
    }

    public static bool isTouchingGround()
    {
        return isGrounded;
    }
}
