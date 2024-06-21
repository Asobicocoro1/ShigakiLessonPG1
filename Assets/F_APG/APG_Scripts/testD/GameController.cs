using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// ゲーム全体のフローを管理するスクリプト。ゲームの開始、ステージのロード、ゲームオーバーの処理、スコア管理などを行います。
/// </summary>
public class GameController : MonoBehaviour
{
    public static GameController instance; // シングルトンインスタンス
    private int score; // 現在のスコア
    private int currentStage; // 現在のステージ番号
    public GameObject player; // プレイヤーオブジェクトの参照
    public GameObject[] stages; // ステージの配列
    public AudioSource BGMSource; // BGM用のオーディオソース
    public AudioSource SFXSource; // 効果音用のオーディオソース
    public AudioClip bgmClip; // BGMのオーディオクリップ
    public AudioClip gameOverClip; // ゲームオーバーの効果音
    public AudioClip gameCompleteClip; // ゲームクリアの効果音
    public AudioClip obstacleDestroyClip; // 障害物破壊の効果音
    private CoinController playerController; // プレイヤーコントローラーの参照

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // このオブジェクトをシーン間で破棄しない
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        playerController = player.GetComponent<CoinController>(); // プレイヤーオブジェクトからPlayerControllerを取得
        StartGame();
    }

    /// <summary>
    /// ゲームを開始するメソッド。スコアの初期化と最初のステージのロードを行います。
    /// </summary>
    public void StartGame()
    {
        score = 0;
        currentStage = 0;
        LoadStage(currentStage);
        PlayBGM(bgmClip);
    }

    /// <summary>
    /// 指定されたステージをロードするメソッド。
    /// </summary>
    /// <param name="stageNumber">ロードするステージの番号</param>
    public void LoadStage(int stageNumber)
    {
        if (stageNumber < stages.Length)
        {
            foreach (GameObject stage in stages)
            {
                stage.SetActive(false);
            }
            stages[stageNumber].SetActive(true);
            player.transform.position = new Vector3(-7, 0, 0);
        }
    }

    /// <summary>
    /// 次のステージへ進むメソッド。全ステージをクリアした場合はゲームクリアを呼び出します。
    /// </summary>
    public void NextStage()
    {
        if (currentStage < stages.Length - 1)
        {
            currentStage++;
            LoadStage(currentStage);
        }
        else
        {
            CompleteGame();
        }
    }

    /// <summary>
    /// ゲームクリアの処理を行うメソッド。
    /// </summary>
    public void CompleteGame()
    {
        UIController.instance.ShowGameComplete();
        PlaySFX(gameCompleteClip);
        Debug.Log("Game Complete!");
    }

    /// <summary>
    /// ゲームオーバーの処理を行うメソッド。
    /// </summary>
    public void GameOver()
    {
        UIController.instance.ShowGameOver();
        PlaySFX(gameOverClip);
        Debug.Log("Game Over!");
    }

    /// <summary>
    /// ゲームを最初から再開始するメソッド。
    /// </summary>
    public void RestartGame()
    {
        StartGame();
    }

    /// <summary>
    /// 指定されたスコアを現在のスコアに追加するメソッド。
    /// </summary>
    /// <param name="amount">追加するスコアの量</param>
    public void AddScore(int amount)
    {
        score += amount;
        UIController.instance.AddScore(score);
    }

    /// <summary>
    /// 指定されたBGMを再生するメソッド。
    /// </summary>
    /// <param name="clip">再生するBGMのオーディオクリップ</param>
    public void PlayBGM(AudioClip clip)
    {
        BGMSource.clip = clip;
        BGMSource.loop = true;
        BGMSource.Play();
    }

    /// <summary>
    /// 指定された効果音を再生するメソッド。
    /// </summary>
    /// <param name="clip">再生する効果音のオーディオクリップ</param>
    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

    /// <summary>
    /// プレイヤーの進化ステージを取得するメソッド。
    /// </summary>
    /// <returns>プレイヤーの進化ステージ</returns>
    public int GetPlayerEvolutionStage()
    {
        return playerController.GetEvolutionStage();
    }
}

