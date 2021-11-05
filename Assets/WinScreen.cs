using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    public GameObject WinScreenUI;
    PlayerMovement Player;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    private void Update()
    {
        if (Player.haveKey == 1)
        {
            Pause();
        }
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

    public void LoadSettings()
    {
        //SceneManager.LoadScene();
    }
}
