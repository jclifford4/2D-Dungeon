using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{

    private float speed = 0.25f;
    private Material mat;
    private float offset;
    // Start is called before the first frame update
    void Start()
    {
        mat = GetComponent<Renderer>().material; 
    }

    // Update is called once per frame
    void Update()
    {
        offset += (Time.deltaTime * speed) / 10f;

        mat.SetTextureOffset("_MainTex", new Vector2(offset, 0));
        
        
    }
}
