using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JGUIController : MonoBehaviour
{
    public GameObject titleScreen;
    public GameObject gameOverScreen;
    public GameObject gameClearScreen;
    public GameObject backToTitleButton; // タイトルに戻るボタン
    public JGSetup gameSetup;
    public JGManager gameManager;

    void Start()
    {
        gameSetup.uiController = this;
        ShowTitleScreen();
    }

    void ShowTitleScreen()
    {
        titleScreen.SetActive(true);
        gameOverScreen.SetActive(false);
        gameClearScreen.SetActive(false);
        backToTitleButton.SetActive(false); // タイトルに戻るボタンを非表示
    }

    public void StartGame()
    {
        titleScreen.SetActive(false);
        gameManager.currentStage = 1; // ステージ1から開始
        gameManager.LoadStage(gameManager.currentStage);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void GameClear()
    {
        gameClearScreen.SetActive(true);

        // Debugログを追加して問題箇所を特定
        Debug.Log("GameClear method called");

        // 次のステージに進むボタンを取得し、リスナーを追加
        Button nextStageButton = gameClearScreen.GetComponentInChildren<Button>();
        if (nextStageButton == null)
        {
            Debug.LogError("Next stage button not found!");
            return;
        }

        nextStageButton.onClick.AddListener(() => {
            gameManager.NextStage();
            gameClearScreen.SetActive(false); // ゲームクリア画面を非表示
        });
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Update()
    {
        if (gameClearScreen.activeSelf && Input.GetKeyDown(KeyCode.Return))
        {
            gameManager.NextStage();
            gameClearScreen.SetActive(false); // ゲームクリア画面を非表示
        }
    }

    public void ShowBackToTitleButton()
    {
        backToTitleButton.SetActive(true);
    }
}
