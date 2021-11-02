using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    [SerializeField] private GameObject player;
    [SerializeField] float enemySpeed = 4f;
    
    //public Transform target;


    void Start()
    {
        
    }


    void Update()
    {


        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, enemySpeed * Time.deltaTime);

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //set player as target
            //alternatively call function for moving towards player if target is already set
        }
    }
}
