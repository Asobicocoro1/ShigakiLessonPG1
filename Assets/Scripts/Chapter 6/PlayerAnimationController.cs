using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// プレイヤーのアニメーションを制御するスクリプト
/// </summary>
public class PlayerAnimationController : MonoBehaviour
{
    // アニメーターコンポーネントへの参照
    private Animator animator;
    // プレイヤーのRigidbody2D
    private Rigidbody2D rb;
    // プレイヤーの速度
    private float speed;
    // プレイヤーが地面に接しているかどうか
    private bool isGrounded;

    void Start()
    {
        // アニメーターコンポーネントを取得
        animator = GetComponent<Animator>();
        // Rigidbody2Dコンポーネントを取得
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // プレイヤーの移動速度を取得
        speed = Input.GetAxis("Horizontal");
        // アニメーターに速度を設定
        animator.SetFloat("Speed", Mathf.Abs(speed));

        // ジャンプ入力を検知し、地面に接している場合にジャンプ
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            animator.SetBool("IsJumping", true);
        }
        else
        {
            animator.SetBool("IsJumping", false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 接触したオブジェクトが地面なら
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // 離れたオブジェクトが地面なら
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}

