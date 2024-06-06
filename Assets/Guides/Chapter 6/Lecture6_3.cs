using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 ### 講義3: プレイヤの動きのスクリプト（6-5 入力に応じてプレイヤを動かそう）

#### 学習の目的の明確化 (1分)
**説明**: プレイヤに入力に応じて動きを与えるスクリプトを作成します。ジャンプや左右移動の実装方法を学びます。

#### 講義 (20分)
**内容**: プレイヤの動きのスクリプト（6-5 入力に応じてプレイヤを動かそう）

##### 6-5-1 スクリプトを使ってジャンプさせる
- **手順**:
  1. Projectウィンドウで「Scripts」フォルダを作成します。
  2. 「Scripts」フォルダ内で右クリックし、「Create」→「C# Script」を選択し、スクリプト名を「PlayerMovement」にします。
  3. PlayerMovementスクリプトをダブルクリックして開き、以下のコードを入力します。

using UnityEngine;

/// <summary>
/// プレイヤーの移動とジャンプを制御するスクリプト
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    // プレイヤーの移動速度
    public float moveSpeed = 5f;
    // ジャンプの力
    public float jumpForce = 5f;
    // Rigidbody2Dコンポーネントへの参照
    private Rigidbody2D rb;
    // プレイヤーが地面に接しているかどうかのフラグ
    private bool isGrounded;

    /// <summary>
    /// 初期設定を行うメソッド
    /// </summary>
    void Start()
    {
        // Rigidbody2Dコンポーネントを取得
        rb = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// フレームごとに呼び出されるメソッド
    /// </summary>
    void Update()
    {
        // 水平入力を取得
        float moveInput = Input.GetAxis("Horizontal");
        // 水平入力に応じてプレイヤーを移動
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // ジャンプ入力を検知し、地面に接している場合にジャンプ
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    /// <summary>
    /// オブジェクトが他のコライダと接触したときに呼ばれるメソッド
    /// </summary>
    /// <param name="collision">接触したコライダの情報</param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 接触したオブジェクトが「Ground」タグを持つ場合
        if (collision.gameObject.CompareTag("Ground"))
        {
            // 地面に接しているフラグをtrueに設定
            isGrounded = true;
        }
    }

    /// <summary>
    /// オブジェクトが他のコライダから離れたときに呼ばれるメソッド
    /// </summary>
    /// <param name="collision">離れたコライダの情報</param>
    private void OnCollisionExit2D(Collision2D collision)
    {
        // 離れたオブジェクトが「Ground」タグを持つ場合
        if (collision.gameObject.CompareTag("Ground"))
        {
            // 地面に接しているフラグをfalseに設定
            isGrounded = false;
        }
    }
}

---------------------------------------------------------------------------------------------------
フィールド
moveSpeed: プレイヤーの移動速度を設定するフィールド。
jumpForce: プレイヤーがジャンプする力を設定するフィールド。
rb: プレイヤーのRigidbody2Dコンポーネントへの参照を格納するフィールド。
isGrounded: プレイヤーが地面に接しているかどうかを判断するためのフラグ。
メソッド
Start(): 初期設定を行うメソッド。Rigidbody2Dコンポーネントを取得します。
Update(): フレームごとに呼び出されるメソッド。プレイヤーの移動とジャンプを制御します。
OnCollisionEnter2D(Collision2D collision): オブジェクトが他のコライダと接触したときに呼ばれるメソッド。地面に接したことを検知します。
OnCollisionExit2D(Collision2D collision): オブジェクトが他のコライダから離れたときに呼ばれるメソッド。地面から離れたことを検知します。
このスクリプトは、プレイヤーの移動とジャンプを制御し、地面との接触を検知してジャンプを可能にします。次に進む前に、各自のUnityプロジェクトにこのスクリプトを実装し、動作を確認してみましょう。


----------------------------------------------------------------------------------------------------

##### 6-5-2 プレイヤにスクリプトをアタッチする
- **手順**:
  1. Hierarchyウィンドウでプレイヤオブジェクトを選択します。
  2. Inspectorウィンドウで「Add Component」をクリックし、「PlayerMovement」スクリプトをアタッチします。

##### 6-5-3 プレイヤに働く重力を調節する
- **手順**:
  1. プレイヤのRigidbody 2Dコンポーネントを選択します。
  2. Inspectorウィンドウで「Gravity Scale」を調整し、適切な重力を設定します。通常はデフォルト値の1で十分ですが、必要に応じて調整します。

##### 6-5-4 プレイヤを左右に移動させる
- **手順**:
  - 上記のスクリプトの中で、`Update`メソッド内に既に記述されています。
  - `Input.GetAxis("Horizontal")`によって、プレイヤの左右移動を制御します。

### Unity上で個人操作 (10分)
- **内容**: ジャンプスクリプトをプレイヤにアタッチし、重力を調整する
  - PlayerMovementスクリプトを作成し、プレイヤオブジェクトにアタッチします。
  - プレイヤのRigidbody 2Dコンポーネントで「Gravity Scale」を調整します。
  - ゲームを実行し、プレイヤの左右移動とジャンプが正しく動作するか確認します。

### 生徒同士で説明 (10分)
- **内容**: 学んだことを互いに説明し合い、理解を深める
  - 各自がどのようにPlayerMovementスクリプトを作成し、プレイヤにアタッチしたかを説明し合います。
  - スクリプトの各部分がどのように機能しているかを互いに確認し合いましょう。

これで、プレイヤの動きをスクリプトで制御する方法を学びました。次の講義では、アニメーションの基本概念について学びます。
 */
public class Lecture6_3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
