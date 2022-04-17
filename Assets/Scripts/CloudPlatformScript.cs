using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudPlatformScript : MonoBehaviour
{

    Vector3 startPosition;
    // Start is called before the first frame update
    private Rigidbody2D player;


    void Awake()
    {
        startPosition = transform.position;
        player = GameObject.Find("Player").GetComponent<Rigidbody2D>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollisionExit2D(Collision2D other)
    {

        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.x);


    }

    private void OnCollisionStay2D(Collision2D other)
    {


        for (int Yoffset = 0; Yoffset < 5; Yoffset++)
        {


            Debug.Log("tranfrom pos y: " + (transform.position.y - startPosition.y));
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log(Time.deltaTime);

                if (transform.position.y - startPosition.y > 18)
                {

                    transform.position = new Vector3(transform.position.x, startPosition.y + 18, transform.position.z);
                    
                    /*Destroy(this.gameObject)*/;

                }

                transform.position = Vector3.MoveTowards(transform.position,
                                                new Vector3(transform.position.x,
                                                            transform.position.y + Yoffset,
                                                            transform.position.z),
                                                            1 * Time.deltaTime);
                other.gameObject.transform.position = new Vector3(other.transform.position.x,
                                                            transform.position.y + .25f,
                                                            other.transform.position.z);
                


            }





        }


    }
}

   
