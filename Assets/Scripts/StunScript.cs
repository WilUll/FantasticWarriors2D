using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunScript : MonoBehaviour
{
    public Transform stunPoint;
    public GameObject stunCharge;

    private float stunCooldown;
    public float startStunCooldown;

    private bool canStun;


    void Start()
    {
        stunCooldown = startStunCooldown;
        canStun = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(1) && canStun == true)
        {
            canStun = false;
            Debug.Log("högerklick");
            GameObject stun = Instantiate(stunCharge, stunPoint.position, stunPoint.rotation);

        }

        if (canStun == false)
        {
            stunCooldown -= Time.deltaTime;
        }

        if (stunCooldown <= 0 && canStun == false)
        {
            canStun = true;
        }

        
    }
}
