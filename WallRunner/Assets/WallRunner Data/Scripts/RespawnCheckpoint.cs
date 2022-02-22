using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCheckpoint : MonoBehaviour
{
    [SerializeField] private Transform pos1;
    [SerializeField] private Transform pos2;
    [SerializeField] private Transform pos3;
    [SerializeField] private Transform pos4;
    [SerializeField] private Transform pos5;
    [SerializeField] private Transform pos6;
    [SerializeField] private Transform player;
    private int checkpointCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody CC = player.GetComponent<Rigidbody>();
        if (other.gameObject.tag == "Checkpoint")
        {
            BoxCollider BC = other.gameObject.GetComponent<BoxCollider>();
            BC.enabled = false;
            checkpointCount++;
        }
        if (other.gameObject.tag == "Respawn")
        {
            if (checkpointCount == 2)
            {
                player.transform.position = pos2.transform.position;   
                    
            }
            else if (checkpointCount == 3)
            {
                player.transform.position = pos3.transform.position;
              
            }
            else if (checkpointCount == 4)
            {
                player.transform.position = pos4.transform.position;
                
            }
            else if (checkpointCount == 5)
            {
                player.transform.position = pos5.transform.position;
               
            }
            else if (checkpointCount == 6)
            {
                player.transform.position = pos6.transform.position;
              
            }
            else
            {
                player.transform.position = pos1.transform.position;
                
            }
        }
    }
}

