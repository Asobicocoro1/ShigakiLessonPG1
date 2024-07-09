using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JGUIController : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject gameOverScreen;
    public GameObject gameClearScreen;

    void Start()
    {
        ShowTitleScreen();
    }

    void ShowTitleScreen()
    {
        titleScreen.SetActive(true);
        gameOverScreen.SetActive(false);
        gameClearScreen.SetActive(false);
    }

    public void StartGame()
    {
        titleScreen.SetActive(false);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void GameClear()
    {
        gameClearScreen.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
