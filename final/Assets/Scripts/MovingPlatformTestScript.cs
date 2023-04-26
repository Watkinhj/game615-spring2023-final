using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformTestScript : MonoBehaviour
{
    float movementSpeed = 2f;
    float movementLimit = 5f;
    float currentMovement = 0;
    float frameMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frameMovement = movementSpeed * Time.deltaTime;
        transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z + frameMovement);
        currentMovement += frameMovement;
        if(currentMovement > movementLimit || currentMovement < -movementLimit)
            movementSpeed = -movementSpeed;
    }
}
