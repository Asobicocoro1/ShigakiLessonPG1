using System.Collections;
using System.Collections.Generic;
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
