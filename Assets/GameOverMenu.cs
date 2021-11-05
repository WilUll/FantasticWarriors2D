using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{

    public GameObject GameOverUI;
    PlayerMovement Player;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
    }

    private void Update()
    {
            if (Player.GameOver)
            {
                Pause();
            }
    }

    
    public void Pause()
    {
        GameOverUI.SetActive(true);
        Time.timeScale = 0f;
        Player.GameOver = true;
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
