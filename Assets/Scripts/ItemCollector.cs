using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{



    public int playerScore;

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Diamond")){
            PlayerManager.Instance.addToScore(1);
            
            //Debug.Log("Score: " + PlayerManager.Instance.score);
            Destroy(collision.gameObject);
            
        }
        
    }


}
