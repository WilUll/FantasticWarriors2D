using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoorWin : MonoBehaviour
{
    bool canExitWin;
    PlayerMovement Player;
    public GameObject WinScreenUI;

   
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canExitWin && Player.haveKey == 1)
        {
            Pause();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        canExitWin = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        canExitWin = false;
    }

    public void Pause()
    {
        WinScreenUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
