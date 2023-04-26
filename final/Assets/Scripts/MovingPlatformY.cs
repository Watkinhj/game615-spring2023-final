using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformY : MonoBehaviour
{
    float movementSpeed = 2f;
    float upperLimit = 8f;
    float lowerLimit = 0f;
    //float currentMovement = 0;
    float frameMovement;
    // Start is called before the first frame update
    void Start()
    {
        if(transform.position.y < 0)
            movementSpeed = -movementSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        frameMovement = movementSpeed * Time.deltaTime;
        transform.position = new Vector3 (transform.position.x, transform.position.y + frameMovement, transform.position.z);
        //currentMovement += frameMovement;
        if(transform.position.y > upperLimit || transform.position.y < lowerLimit)
            movementSpeed = -movementSpeed;
    }
}
