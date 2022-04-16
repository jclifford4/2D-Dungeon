using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Diamond")){
            PlayerManager.Instance.score++;
            Debug.Log("Score: " + PlayerManager.Instance.score);
            Destroy(collision.gameObject);
            
        }
        
    }


}
