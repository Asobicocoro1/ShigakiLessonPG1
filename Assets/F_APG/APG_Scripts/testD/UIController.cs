using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// UI���Ǘ�����X�N���v�g�B�X�R�A�\���A�Q�[���I�[�o�[�\���A�Q�[���N���A�\���Ȃǂ��s���܂��B
/// </summary>
public class UIController : MonoBehaviour
{
    public static UIController instance; // �V���O���g���C���X�^���X
    public Text scoreText; // �X�R�A�e�L�X�g�̎Q��
    public Text gameOverText; // �Q�[���I�[�o�[�e�L�X�g�̎Q��
    public Text gameCompleteText; // �Q�[���N���A�e�L�X�g�̎Q��
    private Animator scoreAnimator; // �X�R�A�e�L�X�g�̃A�j���[�^�[

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        scoreText.text = "Score: 0";
        gameOverText.gameObject.SetActive(false);
        gameCompleteText.gameObject.SetActive(false);
        scoreAnimator = scoreText.GetComponent<Animator>();
    }

    /// <summary>
    /// �X�R�A���X�V���郁�\�b�h�B
    /// </summary>
    /// <param name="score">�X�V����X�R�A�̒l</param>
    public void AddScore(int score)
    {
        scoreText.text = "Score: " + score.ToString();
        scoreAnimator.SetTrigger("ScoreIncrease");
    }

    /// <summary>
    /// �Q�[���I�[�o�[�̃e�L�X�g��\�����郁�\�b�h�B
    /// </summary>
    public void ShowGameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }

    /// <summary>
    /// �Q�[���N���A�̃e�L�X�g��\�����郁�\�b�h�B
    /// </summary>
    public void ShowGameComplete()
    {
        gameCompleteText.gameObject.SetActive(true);
    }
}

