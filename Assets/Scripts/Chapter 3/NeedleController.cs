using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleController : MonoBehaviour
{
    private RouletteController rouletteController;
    public GameObject roulette; // ルーレットオブジェクト

    void Start()
    {
        // ルーレットのコントローラースクリプトを取得
        rouletteController = roulette.GetComponent<RouletteController>();
    }

    void Update()
    {
        // マウスクリックで針の動作を制御
        if (Input.GetMouseButtonDown(0) && !rouletteController.isSpinning) // クリックされ、かつルーレットが回転していない場合
        {
            // ルーレットの回転を遅くして徐々に停止させる
            StartCoroutine(SlowDown());
        }
    }

    IEnumerator SlowDown()
    {
        while (rouletteController.rotationSpeed > 0) // 回転速度が0より大きい間
        {
            rouletteController.rotationSpeed -= Time.deltaTime * 50; // 速度を徐々に減少させる
            yield return null;
        }

        rouletteController.rotationSpeed = 0; // 完全に停止
        rouletteController.isSpinning = false;
    }
}

