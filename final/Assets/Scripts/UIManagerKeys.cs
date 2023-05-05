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
    //public Animator UIToActivateFinalAnim;

    private void OnTriggerEnter(Collider other)
    {
        PlayerMovement CC = player.GetComponent<PlayerMovement>();

        if (other.gameObject.tag == "UITrigger")
        {

            Debug.Log("Picked Up Key: " + GameObject.FindGameObjectsWithTag("key").Length);

            if (GameObject.FindGameObjectsWithTag("key").Length <= 1)
            {
                Debug.Log("Final Key Collected.");
                //UIToActivateAnim.SetTrigger("Deactivated");
                UIToActivateAnim.SetTrigger("FinalActivated");
                //UIToActivateFinalAnim.SetTrigger("Activated");
                UIToDeactivateAnim.SetTrigger("Deactivated");
            }

            else
            {
                UIToActivateAnim.SetTrigger("Activated");
                UIToDeactivateAnim.SetTrigger("Deactivated");
            }
        }
    }
}
