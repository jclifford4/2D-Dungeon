using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{

    [SerializeField] GameObject[] teleporters;
    [SerializeField] GameObject t_entry, t_exit;
    // Start is called before the first frame update
    void Start()
    {
        retrieveTeleRef();

        foreach (GameObject t in teleporters)
        {
            GameObject o = t;
            referenceTeleporters(o);
        }
    }

    private void referenceTeleporters(GameObject o)
    {
        if (o.name.Equals("Teleporter1_entry"))
        {
            t_entry = o;
        }
        else if (o.name.Equals("Teleporter1_exit"))
        {
            t_exit = o;
            
        }
    }

    private void retrieveTeleRef()
    {
        teleporters = GameObject.FindGameObjectsWithTag("Teleporter");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.transform.position = new Vector3(t_exit.transform.position.x,
                                    t_exit.transform.position.y, t_exit.transform.position.z);
        }
    }
}
