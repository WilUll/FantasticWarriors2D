using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    GameObject player;
   
    public float enemySpeed = 2f;
    public float enemyChaseSpeed = 4f;

    public bool inRangeOfPlayer = false;


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }


    void Update()
    {

        if (inRangeOfPlayer)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, enemyChaseSpeed * Time.deltaTime);
        }
        else
        {

        }

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            inRangeOfPlayer = true;
        }
    }
}
