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
    public JGSetup gameSetup; // �Q�[���Z�b�g�A�b�v�X�N���v�g�̎Q��

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
        gameSetup.SetupStage1(); // �X�e�[�W1�𐶐�
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }

    public void GameClear()
    {
        gameClearScreen.SetActive(true);
        // ���̃X�e�[�W�ɐi�ރ{�^����L�������A���X�i�[��ǉ�
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
            NextStage(); // �G���^�[�L�[�������ꂽ�玟�̃X�e�[�W�ɐi��s
        }
    }

    public void NextStage()
    {
        gameClearScreen.SetActive(false);
        //gameSetup.SetupStage2(); // �X�e�[�W2�𐶐�
    }
}
