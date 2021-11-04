using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCatcher : MonoBehaviour
{

    private float killTime;
    public float startKillTime;

    public bool inKillRangeOfPlayer = false;

  
    void Start()
    {
        killTime = startKillTime;
    }

    
    void Update()
    {

        // Lose condition
        if (inKillRangeOfPlayer)
        {
            Debug.Log("killtimer start");
            killTime -= Time.deltaTime;
            if (killTime <= 0)
            {
                Debug.Log("du dog sopa");
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
        }
    }
    // Stops killtimer
    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inKillRangeOfPlayer = false;
        }
    }

}
