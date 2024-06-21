using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// プレイヤーの動作を管理するスクリプト。オートラン、スローモーション、進化、障害物破壊などの処理を行います。
/// </summary>
public class CoinController : MonoBehaviour
{
    public float autoRunSpeed = 5f; // プレイヤーのオートラン速度
    public float increasedSpeed = 8f; // 速度増加時の速度
    private bool isSlowMotion = false; // スローモーション中かどうかのフラグ
    private Vector3 targetPosition; // プレイヤーのターゲット位置
    private int evolutionStage = 0; // プレイヤーの進化ステージ
    public Slider timingSlider; // タイミングスライダー
    private float sliderValue = 0.5f; // スライダーの値
    private bool isSliderIncreasing = true; // スライダーの値が増加中か減少中かのフラグ

    void Update()
    {
        if (isSlowMotion)
        {
            HandleSlowMotion();
        }
        else
        {
            transform.Translate(Vector3.right * autoRunSpeed * Time.deltaTime);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (isSlowMotion)
            {
                EndSlowMotion();
            }
            else
            {
                StartSlowMotion();
            }
        }

        if (!isSlowMotion && Vector3.Distance(transform.position, targetPosition) > 0.1f)
        {
            Vector3 direction = (targetPosition - transform.position).normalized;
            transform.Translate(direction * autoRunSpeed * Time.deltaTime);
        }
    }

    /// <summary>
    /// スローモーション中の処理を行うメソッド。
    /// </summary>
    void HandleSlowMotion()
    {
        // スライダーの値を更新
        if (isSliderIncreasing)
        {
            sliderValue += Time.deltaTime * 0.5f;
            if (sliderValue >= 1f)
            {
                sliderValue = 1f;
                isSliderIncreasing = false;
            }
        }
        else
        {
            sliderValue -= Time.deltaTime * 0.5f;
            if (sliderValue <= 0f)
            {
                sliderValue = 0f;
                isSliderIncreasing = true;
            }
        }

        timingSlider.value = sliderValue;
    }

    /// <summary>
    /// スローモーションを開始するメソッド。
    /// </summary>
    void StartSlowMotion()
    {
        isSlowMotion = true;
        timingSlider.gameObject.SetActive(true);
        sliderValue = 0.5f;
        isSliderIncreasing = true;
    }

    /// <summary>
    /// スローモーションを終了するメソッド。
    /// </summary>
    void EndSlowMotion()
    {
        isSlowMotion = false;
        timingSlider.gameObject.SetActive(false);

        // パーフェクトタイミングの判定
        if (sliderValue >= 0.48f && sliderValue <= 0.52f)
        {
            autoRunSpeed = increasedSpeed;
        }
        else
        {
            autoRunSpeed = 5f;
        }

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
    }

    /// <summary>
    /// プレイヤーを進化させるメソッド。
    /// </summary>
    public void Evolve()
    {
        if (evolutionStage < 3)
        {
            evolutionStage++;
            // 進化時の処理を追加
            Debug.Log("Player evolved to stage " + evolutionStage);
        }
    }

    /// <summary>
    /// プレイヤーの進化ステージを取得するメソッド。
    /// </summary>
    /// <returns>プレイヤーの進化ステージ</returns>
    public int GetEvolutionStage()
    {
        return evolutionStage;
    }

    /// <summary>
    /// コライダーに衝突した時の処理を行うメソッド。
    /// </summary>
    /// <param name="collision">衝突したコライダー</param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ObstacleA") && GetEvolutionStage() >= 1)
        {
            Destroy(collision.gameObject);
            GameController.instance.AddScore(10);
            GameController.instance.PlaySFX(GameController.instance.obstacleDestroyClip);
        }
        else if (collision.gameObject.CompareTag("ObstacleB") && GetEvolutionStage() >= 2)
        {
            Destroy(collision.gameObject);
            GameController.instance.AddScore(20);
            GameController.instance.PlaySFX(GameController.instance.obstacleDestroyClip);
        }
        else if (collision.gameObject.CompareTag("ObstacleC"))
        {
            GameController.instance.GameOver();
        }
        else if (collision.gameObject.CompareTag("GoalLine"))
        {
            GameController.instance.NextStage();
        }
        else if (collision.gameObject.CompareTag("Item"))
        {
            Evolve();
            Destroy(collision.gameObject);
        }
    }
}


