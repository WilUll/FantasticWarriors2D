using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{

    public float patrolSpeed;
    public float startWaitTime;
    private float waitTime;


    public Transform moveSpots;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;


    void Start()
    {
        waitTime = startWaitTime;

        moveSpots.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
    }

 
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots.position, patrolSpeed * Time.deltaTime);

        if(Vector2.Distance(transform.position, moveSpots.position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                Debug.Log("flytta movespot");
                moveSpots.position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
                waitTime = startWaitTime;
            }
            else
            {
                Debug.Log("starta timer");
                waitTime -= Time.deltaTime;
            }

        }
    }
}
