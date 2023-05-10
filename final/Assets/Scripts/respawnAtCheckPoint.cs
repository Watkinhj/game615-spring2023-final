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
    public AudioSource respawnSound;
    public AudioSource keySound;
    public AudioSource firewallSound;
    public GameManager gm;

    public void PlayRespawn()
    {
        respawnSound.Stop();
        respawnSound.Play();
    }

    public void PlayKeySound()
    {
        keySound.Stop();
        keySound.Play();
    }

    public void PlayFirewallSound()
    {
        firewallSound.Stop();
        firewallSound.Play();
    }


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
            if (GameObject.FindGameObjectsWithTag("key").Length <= 1)
            {
                player.transform.position = posMain.transform.position;
                PlayFirewallSound();
                Debug.Log("Teleported Back to Hub Zone.");
                Destroy(other.gameObject);
            }
            
            else
            {
                player.transform.position = posMain.transform.position;
                PlayKeySound();
                Debug.Log("Teleported Back to Hub Zone.");
                Destroy(other.gameObject);
            }
        }
            
        else if (other.gameObject.tag == "respawn1")
        {   
            player.transform.position = pos1.transform.position;
            PlayRespawn();
            Debug.Log("Teleported to Level 1 Start.");
        }
            
        else if (other.gameObject.tag == "respawn2")
        {  
            player.transform.position = pos2.transform.position;
            Debug.Log("Teleported to Level 2 Start.");
            PlayRespawn();
        }
            
        else if (other.gameObject.tag == "respawn3")
        {
            player.transform.position = pos3.transform.position;
            Debug.Log("Teleported to Level 3 Start.");
            PlayRespawn();
        }

        else if (other.gameObject.tag == "respawn4")
        {
            player.transform.position = pos4.transform.position;
            Debug.Log("Teleported to Level 4 Start.");
            gm.resetViruses();
            PlayRespawn();
        }
        else if (other.gameObject.tag == "virus")
        {
            player.transform.position = pos4.transform.position;
            Debug.Log("Teleported to Final Level Start.");
            gm.resetViruses();
            PlayRespawn();
        }

    }
}
