using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoHome : MonoBehaviour
{

    [SerializeField] private Transform player;

    private void OnTriggerEnter(Collider other)
    {
        PlayerMovement CC = player.GetComponent<PlayerMovement>();

        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(GameEndTime());
        }
    }

    public void TitleScreen()
    {
        SceneManager.LoadScene("Title Screen");
    }

    IEnumerator GameEndTime()
    {
        Debug.Log("Starting End Timer...");
        yield return new WaitForSeconds(8);
        Debug.Log("Timer Ended. Returning to Title Screen.");
        TitleScreen();
    }

}
