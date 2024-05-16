using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotationSpeed = 100.0f; // 回転速度

    //protected internal 修飾子は、同じアセンブリ内のすべてのクラスまたは派生クラスからアクセス可能です。
    //これは、継承関係にあるクラス間で変数を共有したい場合に役立ちます。
    //アッセンブリについては「Chapter3Guide」

    protected internal bool isSpinning = false; // 回転中かどうかのフラグ

    void Update()
    {
        // マウスクリックで回転の開始/停止を制御s
        if (Input.GetMouseButtonDown(0))
        {
            isSpinning = !isSpinning; // isSpinningの真偽値を反転させる（falseならtrueに、trueならfalseに）
        }

        // 回転中ならばルーレットを回転させる
        if (isSpinning)
        {
            transform.Rotate(0, 0, rotationSpeed * Time.deltaTime); // Z軸周りに回転
        }
    }
}

