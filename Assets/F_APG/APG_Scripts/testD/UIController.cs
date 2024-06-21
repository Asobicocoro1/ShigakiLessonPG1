using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// UIを管理するスクリプト。スコア表示、ゲームオーバー表示、ゲームクリア表示などを行います。
/// </summary>
public class UIController : MonoBehaviour
{
    public static UIController instance; // シングルトンインスタンス
    public Text scoreText; // スコアテキストの参照
    public Text gameOverText; // ゲームオーバーテキストの参照
    public Text gameCompleteText; // ゲームクリアテキストの参照
    private Animator scoreAnimator; // スコアテキストのアニメーター

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
    /// スコアを更新するメソッド。
    /// </summary>
    /// <param name="score">更新するスコアの値</param>
    public void AddScore(int score)
    {
        scoreText.text = "Score: " + score.ToString();
        scoreAnimator.SetTrigger("ScoreIncrease");
    }

    /// <summary>
    /// ゲームオーバーのテキストを表示するメソッド。
    /// </summary>
    public void ShowGameOver()
    {
        gameOverText.gameObject.SetActive(true);
    }

    /// <summary>
    /// ゲームクリアのテキストを表示するメソッド。
    /// </summary>
    public void ShowGameComplete()
    {
        gameCompleteText.gameObject.SetActive(true);
    }
}

