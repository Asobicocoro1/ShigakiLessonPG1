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
    public GameObject backToTitleButton; // �^�C�g���ɖ߂�{�^��
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
        backToTitleButton.SetActive(false); // �^�C�g���ɖ߂�{�^�����\��
    }

    public void StartGame()
    {
        titleScreen.SetActive(false);
        gameManager.currentStage = 1; // �X�e�[�W1����J�n
        gameManager.LoadStage(gameManager.currentStage);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void GameClear()
    {
        gameClearScreen.SetActive(true);

        // Debug���O��ǉ����Ė��ӏ������
        Debug.Log("GameClear method called");

        // ���̃X�e�[�W�ɐi�ރ{�^�����擾���A���X�i�[��ǉ�
        Button nextStageButton = gameClearScreen.GetComponentInChildren<Button>();
        if (nextStageButton == null)
        {
            Debug.LogError("Next stage button not found!");
            return;
        }

        nextStageButton.onClick.AddListener(() => {
            gameManager.NextStage();
            gameClearScreen.SetActive(false); // �Q�[���N���A��ʂ��\��
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
            gameClearScreen.SetActive(false); // �Q�[���N���A��ʂ��\��
        }
    }

    public void ShowBackToTitleButton()
    {
        backToTitleButton.SetActive(true);
    }
}
