using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusController : MonoBehaviour
{
    Vector3 rotation;
    private GameObject player;
    private GameObject virus;
    const float randomLowerBound = -100f;
    const float randomUpperBound = 100f;
    const float speed = 2f;
    public GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        float randomX = Random.Range(randomLowerBound,randomUpperBound);
        float randomY = Random.Range(randomLowerBound,randomUpperBound);
        float randomZ = Random.Range(randomLowerBound,randomUpperBound);
        rotation = new Vector3(randomX, randomY, randomZ);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotation * Time.deltaTime);

        if(gm.chaseTime)
        {
            //Debug.Log("It begins.");
            Chase();
        }
    }

    private void Chase()
    {
        transform.position = Vector3.MoveTowards(transform.position, gm.player.transform.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Reset!");
            gm.resetViruses();
        }
    }
}
