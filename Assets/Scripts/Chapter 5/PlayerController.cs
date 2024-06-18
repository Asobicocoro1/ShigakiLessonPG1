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
Vector2 movement = new Vector2(moveHorizontal, 0);

Vector2は2次元のベクトル（方向）を表します。ここでは、横方向（X軸）の入力を使って、プレイヤの移動方向を決めています。
transform.Translate(movement * speed * Time.deltaTime);

transform.Translateは、オブジェクトを指定した方向に移動させるメソッドです。movementの方向に、speedの速さで、Time.deltaTime（1フレームの時間）を掛けて移動します。

------------------------------------------------------------------------------------------------------------------------------------------------------------------
 **日本語解説付きのスクリプトの説明**
  - `public float currentHP = 100f;`  
    - プレイヤーの現在のHPを保持する変数です。ゲームの開始時は100です。

  - `void OnTriggerEnter2D(Collider2D other)`  
    - このメソッドは、プレイヤーが他のオブジェクトに触れたときに呼び出されます。`Collider2D`は2Dのコライダーを意味します。

  - `if (other.gameObject.CompareTag("arrow"))`  
    - 触れたオブジェクトが「arrow」というタグを持っているかどうかを確認します。タグは、オブジェクトにラベルを付けるためのものです。

  - `TakeDamage(10f);`  
    - HPを10減らします。

  - `Destroy(other.gameObject);`  
    - 触れたオブジェクト（矢）を消します。

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

public class PlayerControllerEX : MonoBehaviour
{
    public float speed = 10f; // プレイヤの移動速度
    public GameManager_2 gameManager; // GameManagerを参照
    public float currentHP = 100f; // プレイヤーの現在のHP

    private Animator animator; // アニメーターを参照する変数
    private bool isFacingRight = true; // プレイヤーが右を向いているかどうかを示すフラグ

    void Start()
    {
        // アニメーターコンポーネントを取得します
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // 横方向の入力を取得します（矢印キーの左右やAとDキー）
        float moveHorizontal = Input.GetAxis("Horizontal");

        // 移動する方向を決めます。横方向の入力を使います。
        Vector2 movement = new Vector2(moveHorizontal, 0);

        // プレイヤを移動させます。movementの方向にspeedの速さで、時間に合わせて移動します。
        transform.Translate(movement * speed * Time.deltaTime);

        // 横方向の入力が0でない場合、アニメーションを再生します
        if (moveHorizontal != 0)
        {
            animator.SetBool("isWalking", true);

            // 入力に応じてプレイヤーの向きを変更します
            if (moveHorizontal > 0 && !isFacingRight)
            {
                Flip();
            }
            else if (moveHorizontal < 0 && isFacingRight)
            {
                Flip();
            }
        }
        else
        {
            animator.SetBool("isWalking", false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // 矢に触れたとき
        if (other.gameObject.CompareTag("arrow"))
        {
            TakeDamage(10f); // HPを10減らします
            Destroy(other.gameObject); // 矢を消します
        }
    }

    void TakeDamage(float damage)
    {
        currentHP -= damage; // HPを減らす
        gameManager.UpdateHP(currentHP); // HPゲージを更新
    }

    void Flip()
    {
        // プレイヤーの向きを反転させます
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
