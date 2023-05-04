using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerKeys : MonoBehaviour
{
    [SerializeField] private Transform player;
    //public Image UIToActivate;
    //public Image UIToDeactivate;

    public Animator UIToActivateAnim;
    public Animator UIToDeactivateAnim;
    public Animator UIToActivateFinalAnim;


    private void OnTriggerEnter(Collider other)
    {
        PlayerMovement CC = player.GetComponent<PlayerMovement>();

        if (other.gameObject.tag == "Player")
        {
            if (GameObject.FindGameObjectsWithTag("key").Length <= 1)
            {
                Debug.Log("Final Key Collected.");
                UIToActivateFinalAnim.SetBool("Activated", true);
                UIToDeactivateAnim.SetBool("Deactivated", true);
            }

            else
            {
                UIToActivateAnim.SetBool("Activated", true);
                UIToDeactivateAnim.SetBool("Deactivated", true);
            }
        }
    }
}
