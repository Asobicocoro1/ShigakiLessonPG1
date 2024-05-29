using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 日本語解説付きのスクリプトの説明
public float speed = 10f;

プレイヤの移動速度を設定します。例えば、10fとすると、速さが10のスピードで動きます。
void Update()

Updateメソッドは、ゲームのフレームごとに呼び出されます。つまり、1秒間に何回も実行されます。
float moveHorizontal = Input.GetAxis("Horizontal");

Input.GetAxis("Horizontal")は、キーボードの左右の矢印キーやAとDキーの入力を取得します。例えば、右矢印キーを押すと1、左矢印キーを押すと-1の値を返します。
float moveVertical = Input.GetAxis("Vertical");

Input.GetAxis("Vertical")は、キーボードの上下の矢印キーやWとSキーの入力を取得します。例えば、上矢印キーを押すと1、下矢印キーを押すと-1の値を返します。
Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

Vector3は3次元のベクトル（方向）を表します。ここでは、横方向（X軸）と縦方向（Z軸）の入力を使って、プレイヤの移動方向を決めています。
transform.Translate(movement * speed * Time.deltaTime);

transform.Translateは、オブジェクトを指定した方向に移動させるメソッドです。movementの方向に、speedの速さで、Time.deltaTime（1フレームの時間）を掛けて移動します。
 */

public class PlayerController : MonoBehaviour
{
    // プレイヤの移動速度を設定します
    public float speed = 10f;

    void Update()
    {
        // 横方向の入力を取得します（矢印キーの左右やAとDキー）
        float moveHorizontal = Input.GetAxis("Horizontal");
        // 縦方向の入力を取得します（矢印キーの上下やWとSキー）
        float moveVertical = Input.GetAxis("Vertical");

        // 移動する方向を決めます。横方向の入力と縦方向の入力を使います。
        //x,y,zの順
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // プレイヤを移動させます。
        // movementの方向にspeedの速さで、時間に合わせて移動します。
        transform.Translate(movement * speed * Time.deltaTime);
    }
}

