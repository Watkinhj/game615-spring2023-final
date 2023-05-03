using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firewall : MonoBehaviour
{
    int keys;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        keys = GameObject.FindGameObjectsWithTag("key").Length;

        if (GameObject.FindGameObjectsWithTag("key").Length <= 0)
        {
            Debug.Log("Disabling Firewall.");
            Destroy(gameObject);
        }
    }
}
