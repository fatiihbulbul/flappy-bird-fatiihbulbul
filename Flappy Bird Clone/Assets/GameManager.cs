using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject playButton;
    public GameObject gameOver;
    public GameObject logo;

    private void Start()
    {
        Time.timeScale = 1;
        playButton.SetActive(false);
        gameOver.SetActive(false);
        logo.SetActive(false);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        playButton.SetActive(true);
        gameOver.SetActive(true);
        logo.SetActive(true);
        
    }

    public void Retry()
    {
        SceneManager.LoadScene(0);
    }
}
