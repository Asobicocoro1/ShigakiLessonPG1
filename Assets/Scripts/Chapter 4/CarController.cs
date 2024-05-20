using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    // スワイプの開始位置を保存する変数
    private Vector2 startMousePosition;
    // スワイプの終了位置を保存する変数
    private Vector2 endMousePosition;
    // 車の物理的な動きを制御するためのRigidbody2Dコンポーネント
    private Rigidbody2D rb;

    // 最初に一度だけ呼ばれる関数
    void Start()
    {
        // Rigidbody2Dコンポーネントを取得して変数に保存
        rb = GetComponent<Rigidbody2D>();
    }

    // 毎フレーム（毎秒何十回も）呼ばれる関数
    void Update()
    {
        // マウスボタンが押された瞬間の処理
        if (Input.GetMouseButtonDown(0))
        {
            // スワイプの開始位置を保存
            startMousePosition = Input.mousePosition;
        }
        // マウスボタンが離された瞬間の処理
        else if (Input.GetMouseButtonUp(0))
        {
            // スワイプの終了位置を保存
            endMousePosition = Input.mousePosition;
            // 車を動かす関数を呼び出す
            MoveCar();
        }
    }

    // 車を動かすための関数
    void MoveCar()
    {
        // スワイプのベクトル（方向と距離）を計算
        Vector2 swipeVector = endMousePosition - startMousePosition;
        // スワイプの距離を計算
        float swipeDistance = swipeVector.magnitude;

        // スワイプの方向を計算（ベクトルを正規化）
        Vector2 direction = swipeVector.normalized;
        // 車に力を加えて動かす（スワイプの距離に応じて）
        rb.AddForce(direction * swipeDistance * 0.1f, ForceMode2D.Impulse);
    }

    /*
     
     * 
using UnityEngine;

public class CarController : MonoBehaviour
{
    // スワイプの開始位置を保存する変数
    private Vector2 startTouchPosition;
    // スワイプの終了位置を保存する変数
    private Vector2 endTouchPosition;
    // 車の物理的な動きを制御するためのRigidbody2Dコンポーネント
    private Rigidbody2D rb;

    // 最初に一度だけ呼ばれる関数
    void Start()
    {
        // Rigidbody2Dコンポーネントを取得して変数に保存
        rb = GetComponent<Rigidbody2D>();
    }

    // 毎フレーム（毎秒何十回も）呼ばれる関数
    void Update()
    {
        // 画面に触れている指の数が1本以上の場合
        if (Input.touchCount > 0)
        {
            // 一番最初の指の情報を取得
            Touch touch = Input.GetTouch(0);

            // 画面に触れた瞬間の処理
            if (touch.phase == TouchPhase.Began)
            {
                // スワイプの開始位置を保存
                startTouchPosition = touch.position;
            }
            // 画面から指が離れた瞬間の処理
            else if (touch.phase == TouchPhase.Ended)
            {
                // スワイプの終了位置を保存
                endTouchPosition = touch.position;
                // 車を動かす関数を呼び出す
                MoveCar();
            }
        }
    }

    // 車を動かすための関数
    void MoveCar()
    {
        // スワイプのベクトル（方向と距離）を計算
        Vector2 swipeVector = endTouchPosition - startTouchPosition;
        // スワイプの距離を計算
        float swipeDistance = swipeVector.magnitude;

        // スワイプの方向を計算（ベクトルを正規化）
        Vector2 direction = swipeVector.normalized;
        // 車に力を加えて動かす（スワイプの距離に応じて）
        rb.AddForce(direction * swipeDistance * 0.1f, ForceMode2D.Impulse);
    }
}

      
     */
}


