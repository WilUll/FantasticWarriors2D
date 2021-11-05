using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunScript : MonoBehaviour
{
    public Transform stunPoint;
    public GameObject stunCharge;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("högerklick");
            GameObject bullet = Instantiate(stunCharge, stunPoint.position, stunPoint.rotation);
        }
        
    }
}
