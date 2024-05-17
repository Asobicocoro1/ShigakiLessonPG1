using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Roulette : MonoBehaviour
{
    // 針のオブジェクト
    public GameObject needle;

    // テキストオブジェクト
    public Text resultText;

    // ルーレットの回転速度
    private float rotationSpeed = 50.0f;

    // ルーレットの回転角度
    private float rotationAngle = 0.0f;

    // ルーレットの停止フラグ
    private bool isStopped = false;

    // Start() 関数
    void Start()
    {
        // 最初に針をランダムな角度に回転させる
        needle.transform.Rotate(0.0f, 0.0f, Random.Range(0.0f, 360.0f));
    }

    // Update() 関数
    void Update()
    {
        // ルーレットが回転していない場合は処理をスキップ
        if (isStopped)
        {
            return;
        }

        // 針を回転させる
        needle.transform.Rotate(0.0f, 0.0f, rotationSpeed * Time.deltaTime);

        // ルーレットの回転角度を更新する
        rotationAngle += rotationSpeed * Time.deltaTime;

        // ルーレットの回転を停止するタイミングを検知する
        if (rotationAngle >= 3600.0f)
        {
            // ルーレットの回転を停止する
            rotationSpeed = 0.0f;

            // 停止した場所をランダムに決定する
            int result = Random.Range(0, 36);

            // 結果をテキストに表示する
            resultText.text = "結果：" + result.ToString();

            // ルーレットの停止フラグを立てる
            isStopped = true;
        }
    }
}

