using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCatcher : MonoBehaviour
{

    private float killTime;
    public float startKillTime;

    public bool inKillRangeOfPlayer = false;

    PlayerMovement DeadPlayer;

    AudioSource audioSource;
    public AudioClip[] Clips;
    bool playClips = true;


    void Start()
    {
        killTime = startKillTime;
        DeadPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        audioSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {

        // Lose condition
        if (inKillRangeOfPlayer)
        {
            Debug.Log("Death range");
            killTime -= Time.deltaTime;
            if (killTime <= 0)
            {
                DeadPlayer.GameOver = true;
            }
        }
        else
        {
            killTime = startKillTime;
        }
        
    }

    // Triggers killtimer
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inKillRangeOfPlayer = true;

            if (playClips)
            {
                audioSource.PlayOneShot(Clips[0]);
                playClips = false;
            }

        }
    }
    // Stops killtimer
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inKillRangeOfPlayer = false;

            playClips = true;
        }
    }

}
