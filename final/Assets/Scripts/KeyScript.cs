using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    [SerializeField] private Transform posMain;
    [SerializeField] private Transform player;

    private void OnTriggerEnter(Collider other)
    {
        PlayerMovement CC = player.GetComponent<PlayerMovement>();

        if (other.gameObject.tag == "Player")
        {
            player.transform.position = posMain.transform.position;
            Debug.Log("Key Collected. Teleporting back to Hub Zone.");
            Destroy(gameObject);
        }
    }
}
