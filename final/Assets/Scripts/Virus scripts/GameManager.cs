using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    const int numViruses = 20;
    public GameObject player;
    public GameObject virus;
    public GameObject finalMusicObject;
    public GameObject mainMusicObject;
    public AudioSource finalMusic;
    public AudioSource mainMusic;
    GameObject[] viruses = new GameObject[numViruses];
    const float xLowerBound = -25f;
    const float xUpperBound = 25f;
    const float yLowerBound = 20f;
    const float yUpperBound = 40f;
    const float zLowerBound = 50f;
    const float zUpperBound = 100f;
    const float playerChaseThreshold = 38f;
    const float musicThreshold = 33f;
    private Vector3 startPosition;
    public bool chaseTime = false;
    private bool finalMusicJustActivated = true;

    // Start is called before the first frame update
    void Start()
    {
        finalMusic = finalMusicObject.GetComponent<AudioSource>();
        mainMusic = mainMusicObject.GetComponent<AudioSource>();

        for(int i = 0; i < numViruses; ++i)
        {
            startPosition = new Vector3(Random.Range(xLowerBound, xUpperBound), Random.Range(yLowerBound, yUpperBound),
                Random.Range(zLowerBound, zUpperBound));
            viruses[i] = Instantiate(virus, startPosition, Quaternion.identity);
            viruses[i].GetComponent<VirusController>().gm = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.z > playerChaseThreshold)
            chaseTime = true;
        else if(player.transform.position.z > musicThreshold && finalMusicJustActivated)
        {
            finalMusicJustActivated = false;
            mainMusic.Stop();
            finalMusic.Play();
        }
        
    }

    public void resetViruses()
    {
        for(int i = 0; i < numViruses; ++i)
        {
            startPosition = new Vector3(Random.Range(xLowerBound, xUpperBound), Random.Range(yLowerBound, yUpperBound),
                Random.Range(zLowerBound, zUpperBound));
            viruses[i].transform.position = startPosition;
        }
    }
}
