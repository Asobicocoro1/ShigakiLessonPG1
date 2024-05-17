using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RouletteController : MonoBehaviour
{
    public float maxRotationSpeed = 360.0f; // 最大回転速度（度/秒）
    protected internal float currentRotationSpeed = 0f; // 現在の回転速度

    //protected internal 修飾子は、同じアセンブリ内のすべてのクラスまたは派生クラスからアクセス可能です。
    //これは、継承関係にあるクラス間で変数を共有したい場合に役立ちます。
    //アッセンブリについては「Chapter3Guide」
    protected internal bool isSpinning = false; // 回転中かどうかのフラグ

    void Update()
    {
        // ユーザーがマウスボタンを押下し、ルーレットが現在回転していない場合に回転を開始する
        if (Input.GetMouseButtonDown(0) && !isSpinning)
        {
            StartSpinning();
        }

        // ルーレットが回転中の場合の処理
        if (isSpinning)
        {
            // 回転速度がまだ0より大きい場合、回転速度を減速させる
            if (currentRotationSpeed > 0)
            {
                currentRotationSpeed -= Time.deltaTime * maxRotationSpeed / 2;
            }
            else
            {
                // 回転速度が0以下になったら回転を停止
                currentRotationSpeed = 0;
                isSpinning = false;
            }

            // ルーレットを現在の速度で回転させる
            transform.Rotate(0, 0, currentRotationSpeed * Time.deltaTime);
        }
    }

    // ルーレットの回転を開始するメソッド
    private void StartSpinning()
    {
        isSpinning = true;
        // 回転速度をランダムに設定する（最小半分から最大まで）
        currentRotationSpeed = Random.Range(maxRotationSpeed * 0.5f, maxRotationSpeed);
    }
}


