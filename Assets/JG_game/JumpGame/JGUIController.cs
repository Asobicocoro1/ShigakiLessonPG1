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
    public JGSetup gameSetup; // ゲームセットアップスクリプトの参照

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
        gameSetup.SetupStage1(); // ステージ1を生成
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void GameClear()
    {
        gameClearScreen.SetActive(true);
        // 次のステージに進むボタンを有効化し、リスナーを追加
        Button nextStageButton = gameClearScreen.GetComponentInChildren<Button>();
        nextStageButton.onClick.AddListener(() => NextStage());
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Update()
    {
        if (gameClearScreen.activeSelf && Input.GetKeyDown(KeyCode.Return))
        {
            NextStage(); // エンターキーが押されたら次のステージに進むs
        }
    }

    public void NextStage()
    {
        gameClearScreen.SetActive(false);
        //gameSetup.SetupStage2(); // ステージ2を生成
    }
}
