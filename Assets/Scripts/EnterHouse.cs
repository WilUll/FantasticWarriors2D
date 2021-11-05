using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterHouse : MonoBehaviour
{
    CameraMovement cameraCheck;
    bool canOpenDoor;

    GameObject player;

    GameObject insideHouse;

    GameObject outsideHouse; 

    private void Start()
    {
        cameraCheck = GameObject.FindWithTag("MainCamera").GetComponent<CameraMovement>();

        player = GameObject.FindGameObjectWithTag("Player");

        insideHouse = GameObject.FindGameObjectWithTag("InsideHousePos");

        outsideHouse = GameObject.FindGameObjectWithTag("OutsideHousePos");
    }

    private void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.E) && canOpenDoor && !cameraCheck.isInside)
        {
            cameraCheck.isInside = true;
            player.transform.position = insideHouse.transform.position;
        }
        else if (Input.GetKeyDown(KeyCode.E) && canOpenDoor && cameraCheck.isInside)
        {
            cameraCheck.isInside = false;
            player.transform.position = outsideHouse.transform.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        canOpenDoor = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canOpenDoor = false;

    }
}
