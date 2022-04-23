using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    [SerializeField] GameObject spawnPoint, objPlayer, fakeBlock;
    [SerializeField] Transform player, spawn;
    [SerializeField] GameObject[] fakeBlocksList;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint");
        spawn = spawnPoint.transform;

        objPlayer = GameObject.FindGameObjectWithTag("Player");
        player = objPlayer.transform;

        
        retrieveFakeBlockRefs();



    }

    private void retrieveFakeBlockRefs()
    {
        fakeBlocksList = GameObject.FindGameObjectsWithTag("PadLimited");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("KillBox"))
        {
            respawn();
            respawnBlocks();
        }
    }

    private void respawnBlocks()
    {
        foreach (GameObject block in fakeBlocksList)
        {
            block.SetActive(true);
        }
    }

    void respawn()
    {
        objPlayer.transform.position = spawn.transform.position;
    }
}
