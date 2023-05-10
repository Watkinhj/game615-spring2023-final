using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firewall : MonoBehaviour
{
    int keys;
    //private GameObject firewallDownSoundObject;
    //private AudioSource firewallDownSound;

    // Start is called before the first frame update
    void Start()
    {
        //firewallDownSoundObject = GameObject.FindWithTag("firewallDownSound");
        //firewallDownSound = firewallDownSoundObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        keys = GameObject.FindGameObjectsWithTag("key").Length;

        if (GameObject.FindGameObjectsWithTag("key").Length <= 0)
        {
            //firewallDownSound.Play();
            Debug.Log("Disabling Firewall.");
            Destroy(gameObject);
            //Destroy(firewallDownSoundObject);
        }
    }
}
