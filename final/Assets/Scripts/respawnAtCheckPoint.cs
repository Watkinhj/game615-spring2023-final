using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnAtCheckPoint : MonoBehaviour
{

    // THIS IS A REPURPOSED SCRIPT I MADE A LONG TIME AGO FOR A PREVIOUS GAME. ALL THE COMMENTED STUFF IS OLD CODE. 

    [SerializeField] private Transform posMain;
    [SerializeField] private Transform pos1;
    [SerializeField] private Transform pos2;
    [SerializeField] private Transform pos3;
    [SerializeField] private Transform pos4;
    [SerializeField] private Transform player;
    //private int checkpointCount = 1;
    //public AudioSource Zap;

    /*
    public void PlayZap()
    {
        Zap.Stop();
        Zap.Play();
    }
    */


    private void OnTriggerEnter(Collider other)
    {
        PlayerMovement CC = player.GetComponent<PlayerMovement>();
        /*
        if (other.gameObject.tag == "checkpoint")
        {
            BoxCollider BC = other.gameObject.GetComponent<BoxCollider>();
            checkpointCount++;
        }
        */

        if (other.gameObject.tag == "key")
        {
            player.transform.position = posMain.transform.position;
            //PlayZap();
            Debug.Log("Teleported Back to Hub Zone.");
            Destroy(other.gameObject);
        }
            
        else if (other.gameObject.tag == "respawn1")
        {   
            player.transform.position = pos1.transform.position;
            //PlayZap();
            Debug.Log("Teleported to Level 1 Start.");
        }
            
        else if (other.gameObject.tag == "respawn2")
        {  
            player.transform.position = pos2.transform.position;
            Debug.Log("Teleported to Level 2 Start.");
            //PlayZap(); 
        }
            
        else if (other.gameObject.tag == "respawn3")
        {
            player.transform.position = pos3.transform.position;
            Debug.Log("Teleported to Level 3 Start.");
            //PlayZap();
        }

        else if (other.gameObject.tag == "respawn4")
        {
            player.transform.position = pos4.transform.position;
            Debug.Log("Teleported to Level 4 Start.");
            //PlayZap();
        }
        else if (other.gameObject.tag == "virus")
        {
            player.transform.position = pos4.transform.position;
            Debug.Log("Teleported to Final Level Start.");
            //PlayZap();
        }

    }
}
