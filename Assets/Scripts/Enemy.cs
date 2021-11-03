using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    /////////
    public GameObject player;
    public Transform moveSpots;

    private float waitTime;
    public float startWaitTime;



    public float enemySpeed = 4f;
    public float enemyChaseSpeed = 4.5f;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public bool inRangeOfPlayer = false;
    
    /////////

    void Start()
    {
        waitTime = startWaitTime;
        
        moveSpots.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }


    /////////
    void Update()
    {

        if (inRangeOfPlayer)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, enemyChaseSpeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, moveSpots.position, enemySpeed * Time.deltaTime);

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

    }

    /////////

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRangeOfPlayer = true;
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inRangeOfPlayer = false;
        }
    }


    /////////
}
