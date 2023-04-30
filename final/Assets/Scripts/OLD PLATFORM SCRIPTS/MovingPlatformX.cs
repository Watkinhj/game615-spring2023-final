using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformX : MonoBehaviour
{
    float movementSpeed = 2f;
    float upperLimit = 6.01f;
    float lowerLimit = -8.01f;
    //float currentMovement = 0;
    float frameMovement;
    // Start is called before the first frame update
    void Start()
    {
        if(transform.position.x > 0)
            movementSpeed = -movementSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        frameMovement = movementSpeed * Time.deltaTime;
        transform.position = new Vector3 (transform.position.x + frameMovement, transform.position.y, transform.position.z);
        //currentMovement += frameMovement;
        if(transform.position.x > upperLimit || transform.position.x < lowerLimit)
            movementSpeed = -movementSpeed;
    }
}
