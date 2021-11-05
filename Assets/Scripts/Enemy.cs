using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    /////////
    GameObject player;
    public Transform moveSpots;
    private AudioSource audioSource;

    private float waitTime;
    public float startWaitTime;


    public AudioClip iSeeYou;


    public float enemySpeed;
    public float enemyChaseSpeed;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    private float speed1;
    private float speed2;

    public bool inRangeOfPlayer = false;
    public bool isStunned = false;

    
    /////////

    void Start()
    {
        speed1 = enemySpeed;
        speed2 = enemyChaseSpeed;


        player = GameObject.FindGameObjectWithTag("Player");

        audioSource = GetComponent<AudioSource>();


        waitTime = startWaitTime;
        
        moveSpots.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }


    /////////
    void Update()
    {

        //Rangefinder and movement
        if (inRangeOfPlayer && isStunned == false)
        {
            Debug.Log("In range of player");
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed2 * Time.deltaTime);
            transform.right = player.transform.position - transform.position;

            audioSource.PlayOneShot(iSeeYou, 1f);
        }
        else
        {

            transform.position = Vector2.MoveTowards(transform.position, moveSpots.position, speed1 * Time.deltaTime);
            transform.right = moveSpots.position - transform.position;


            if (Vector2.Distance(transform.position, moveSpots.position) < 0.2f)
            {
                if (waitTime <= 0)
                {
                    Debug.Log("flytta movespot");
                    moveSpots.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
                    waitTime = startWaitTime;
                }
                else
                {
                    Debug.Log("patrol timer");
                    waitTime -= Time.deltaTime;
                }

            }
        }

        if (isStunned)
        {
            Debug.Log("You have been stunned");

            speed1 = 0f;
            speed2 = 0f;


        }
        else
        {
            speed1 = enemySpeed;
            speed2 = enemyChaseSpeed;
        }
        
        
        
        


    }

    /////////

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRangeOfPlayer = true;
        }

        if (other.gameObject.CompareTag("Stun"))
        {
            isStunned = true;
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRangeOfPlayer = false;
        }

        if (other.gameObject.CompareTag("Stun"))
        {
            isStunned = false;
        }
    }


    /////////
}
