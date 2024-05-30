using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
日本語解説付きのスクリプトの説明
public float speed = 5f;

プレイヤの移動速度を設定します。例えば、5fとすると、速さが5のスピードで動きます。
void Update()

Updateメソッドは、ゲームのフレームごとに呼び出されます。つまり、1秒間に何回も実行されます。
float moveHorizontal = Input.GetAxis("Horizontal");

Input.GetAxis("Horizontal")は、キーボードの左右の矢印キーやAとDキーの入力を取得します。例えば、右矢印キーを押すと1、左矢印キーを押すと-1の値を返します。
float moveVertical = Input.GetAxis("Vertical");

Input.GetAxis("Vertical")は、キーボードの上下の矢印キーやWとSキーの入力を取得します。例えば、上矢印キーを押すと1、下矢印キーを押すと-1の値を返します。
Vector2 movement = new Vector2(moveHorizontal, moveVertical);

Vector2は2次元のベクトル（方向）を表します。ここでは、横方向（X軸）と縦方向（Y軸）の入力を使って、プレイヤの移動方向を決めています。
transform.Translate(movement * speed * Time.deltaTime);

transform.Translateは、オブジェクトを指定した方向に移動させるメソッドです。movementの方向に、speedの速さで、Time.deltaTime（1フレームの時間）を掛けて移動します。

 ------------------------------------------------------------------------------------------------------------------------------------------------------------------
 **日本語解説付きのスクリプトの説明**
  - `public int score = 0;`  
    - プレイヤーのスコアを保持する変数です。ゲームの開始時は0です。

  - `void OnTriggerEnter2D(Collider2D other)`  
    - このメソッドは、プレイヤーが他のオブジェクトに触れたときに呼び出されます。`Collider2D`は2Dのコライダーを意味します。

  - `if (other.gameObject.CompareTag("arrow"))`  
    - 触れたオブジェクトが「arrow」というタグを持っているかどうかを確認します。タグは、オブジェクトにラベルを付けるためのものです。

  - `score += 1;`  
    - スコアを1増やします。

  - `Destroy(other.gameObject);`  
    - 触れたオブジェクト（アイテム）を消します。

#### コライダーの追加
- **プレイヤーとアイテムにコライダーを追加しよう**
  - プレイヤーオブジェクトを選択し、「インスペクター」ウィンドウで「Add Component（コンポーネントを追加）」をクリックします。
  - 「Box Collider 2D」または「Circle Collider 2D」を選びます。プレイヤーの形に合ったコライダーを選びます。
  - 同様に、アイテムオブジェクトにもコライダーを追加します。
  - コライダーの「Is Trigger」にチェックを入れます。これにより、当たり判定が「トリガー」として機能し、物理的な衝突はしませんが、触れたことを検出できます。
 
 
-----------------------------------
日本語解説
public GameManager gameManager;

これは、GameManagerスクリプトを参照するためのものです。これにより、プレイヤーがダメージを受けたときにHPゲージを更新することができます。
public float currentHP = 100f;

これは、プレイヤーの現在のHPを表します。ゲームの開始時には、HPが100に設定されています。
void TakeDamage(float damage)

これは、プレイヤーがダメージを受けたときに呼び出されるメソッドです。ダメージの量を引数として受け取ります。
currentHP -= damage;

これは、受けたダメージの量だけHPを減らします。
gameManager.UpdateHP(currentHP);

これは、減ったHPをGameManagerに通知し、HPゲージを更新するためのメソッドです。


 */

public class PlayerController : MonoBehaviour
{
    // プレイヤの移動速度を設定します
    public float speed = 10f;

    public int score = 0; // プレイヤーのスコアを保持します

    public GameManager_2 gameManager_2; // GameManagerを参照
    public float currentHP = 100f; // プレイヤーの現在のHP


    void Update()
    {
        // 横方向の入力を取得します（矢印キーの左右やAとDキー）
        float moveHorizontal = Input.GetAxis("Horizontal");
        // 縦方向の入力を取得します（矢印キーの上下やWとSキー）
       // float moveVertical = Input.GetAxis("Vertical");

        // 移動する方向を決めます。横方向の入力と縦方向の入力を使います。
        Vector2 movement = new Vector2(moveHorizontal,0);
        // moveVertical
        // プレイヤを移動させます。
        // movementの方向にspeedの速さで、時間に合わせて移動します。
        transform.Translate(movement * speed * Time.deltaTime);
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        // アイテムに触れたとき
        if (other.gameObject.CompareTag("arrow"))
        {
            score += 1; // スコアを1増やします
            TakeDamage(10f); // HPを10減らします 
            Destroy(other.gameObject); // アイテムを消します
        }
    }

    void TakeDamage(float damage)
    {
        currentHP -= damage; // HPを減らす
        gameManager_2.UpdateHP(currentHP); // HPゲージを更新
    }
}

