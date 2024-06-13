using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// ゴールの旗に触れたときの処理を管理するスクリプト
/// </summary>
public class GoalFlag : MonoBehaviour
{
    /// <summary>
    /// プレイヤーが旗に触れたときに呼ばれるメソッド
    /// </summary>
    /// <param name="collision">衝突したオブジェクトの情報</param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // もし衝突したオブジェクトがプレイヤーなら
        if (collision.gameObject.CompareTag("Player"))
        {
            // 次のシーンに遷移
            SceneManager.LoadScene("Chapter6_1");
        }
    }
}
