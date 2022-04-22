using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorScript : MonoBehaviour
{

    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>();
        sr.color = PlayerManager.Instance.getColorValue();

        

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
