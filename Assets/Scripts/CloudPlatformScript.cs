using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudPlatformScript : MonoBehaviour
{

    Vector3 startPosition;
    // Start is called before the first frame update

    void Awake(){
        startPosition = transform.position;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // void OnCollisionEnter2D(Collision2D other){

    //     if (other.gameObject.CompareTag("Player")){
    //         Vector3 newPosition = new Vector3(startPosition.x, startPosition.y + 10, startPosition.z);
    //     }

    // }    
}
