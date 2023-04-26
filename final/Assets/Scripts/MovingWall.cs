using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour
{
    float movementSpeed = 2f;
    float movementLimit = 1f;
    float currentMovement = 0f;
    float frameMovement;
    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.tag == "startMovingDown")
            movementSpeed = -movementSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        frameMovement = movementSpeed * Time.deltaTime;
        transform.position = new Vector3 (transform.position.x, transform.position.y + frameMovement, transform.position.z);
        currentMovement += frameMovement;
        if(currentMovement > movementLimit || currentMovement < -movementLimit)
            movementSpeed = -movementSpeed;
    }
}