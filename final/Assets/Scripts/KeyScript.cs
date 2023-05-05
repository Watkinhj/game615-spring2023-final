using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    [SerializeField] private Transform posMain;
    [SerializeField] private Transform player;
    private GameObject keyCollectedSoundObject;
    private AudioSource keyCollectedSound;

    void Start()
    {
        keyCollectedSoundObject = GameObject.FindWithTag("keyCollectedSound");
        keyCollectedSound = keyCollectedSoundObject.GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerMovement CC = player.GetComponent<PlayerMovement>();

        if (other.gameObject.tag == "Player")
        {
            keyCollectedSound.Play();
            player.transform.position = posMain.transform.position;
            Debug.Log("Key Collected. Teleporting back to Hub Zone.");
            Destroy(gameObject);
        }
    }
}
