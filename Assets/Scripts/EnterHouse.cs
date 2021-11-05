using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterHouse : MonoBehaviour
{
    CameraMovement cameraCheck;
    bool canOpenDoor;

    GameObject player;

    GameObject insideHouse;

    PlayerMovement playerScript;

    private void Start()
    {
        cameraCheck = GameObject.FindWithTag("MainCamera").GetComponent<CameraMovement>();

        player = GameObject.FindGameObjectWithTag("Player");

        playerScript = player.GetComponent<PlayerMovement>();
    }

    private void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.E) && canOpenDoor && !cameraCheck.isInside)
        {
            insideHouse = this.gameObject.transform.GetChild(0).gameObject;
            cameraCheck.isInside = true;
            playerScript.lastPlayerPos =  player.transform.position;
            player.transform.position = insideHouse.transform.position;
        }
        else if (Input.GetKeyDown(KeyCode.E) && canOpenDoor && cameraCheck.isInside)
        {
            cameraCheck.isInside = false;
            player.transform.position = playerScript.lastPlayerPos;
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
