using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    [SerializeField] GameObject spawnPoint, objPlayer;
    [SerializeField] Transform player, spawn;
    // Start is called before the first frame update
    void Start()
    {
        spawnPoint = GameObject.FindGameObjectWithTag("SpawnPoint");
        spawn = spawnPoint.transform;

        objPlayer = GameObject.FindGameObjectWithTag("Player");
        player = objPlayer.transform;

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
        }
    }

    


    void respawn()
    {
        objPlayer.transform.position = spawn.transform.position;
    }
}
