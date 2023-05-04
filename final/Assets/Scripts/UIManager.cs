using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Transform player;
    //public Image UIToActivate;
    //public Image UIToDeactivate;

    public Animator UIToActivateAnim;
    public Animator UIToDeactivateAnim;

    private void OnTriggerEnter(Collider other)
    {
        PlayerMovement CC = player.GetComponent<PlayerMovement>();

        if (other.gameObject.tag == "Player")
        {
            Debug.Log("Hit UI trigger.");
            UIToActivateAnim.SetBool("Activated", true);
            UIToDeactivateAnim.SetBool("Deactivated", true);
        }
    }
}
