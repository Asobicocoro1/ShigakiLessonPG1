using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 用語の解説
1. Animator（アニメーター）
説明: Animatorは、キャラクターやオブジェクトのアニメーションを管理するコンポーネントです。プレイヤーの歩行やジャンプなどの動きをアニメーション化します。
2. Rigidbody2D（リジッドボディ2D）
説明: Rigidbody2Dは、2D物理演算を行うコンポーネントです。重力や衝突の影響を受けてオブジェクトが動きます。このスクリプトでは、プレイヤーのジャンプを制御します。
3. Transform（トランスフォーム）
説明: Transformは、ゲームオブジェクトの位置、回転、スケールの情報を持つコンポーネントです。スクリプトでは使用しませんが、プレイヤーの位置を管理するために重要です。
4. オフセット
説明: オフセットは、基準点からのずれを表します。このスクリプトでは使いませんが、カメラとプレイヤーの位置関係を保つために使用されることがあります。
5. フラグ
説明: フラグは、ある条件が成り立つかどうかを示すための変数です。このスクリプトでは、プレイヤーが地面に接しているかどうかを示すためにisGroundedフラグを使います。
スクリプトの流れの説明
Startメソッド:

ゲームが始まったときに一度だけ呼ばれます。
アニメーターコンポーネントとRigidbody2Dコンポーネントを取得します。
Updateメソッド:

毎フレーム呼ばれます。
プレイヤーの移動速度を取得し、アニメーターのSpeedパラメーターを更新します。
プレイヤーが地面に接していない場合、IsJumpingパラメーターをtrueに設定し、ジャンプアニメーションを再生します。
OnCollisionEnter2Dメソッド:

プレイヤーが他のオブジェクトに接触したときに呼ばれます。
接触したオブジェクトが「Ground」タグを持つ場合、isGroundedフラグをtrueに設定します。
OnCollisionExit2Dメソッド:

プレイヤーが他のオブジェクトから離れたときに呼ばれます。
離れたオブジェクトが「Ground」タグを持つ場合、isGroundedフラグをfalseに設定します。
これにより、プレイヤーのアニメーションが適切に制御され、地面に接しているかどうかによってアニメーションが切り替わります。
 */

/// <summary>
/// プレイヤーのアニメーションを制御するスクリプト
/// </summary>
public class PlayerAnimationController : MonoBehaviour
{
    // アニメーターコンポーネントへの参照
    private Animator animator;
    // プレイヤーのRigidbody2D（物理エンジンのコンポーネント）
    private Rigidbody2D rb;
    // プレイヤーが地面に接しているかどうかのフラグ
    private bool isGrounded;

    /// <summary>
    /// 初期設定を行うメソッド
    /// ゲーム開始時に一度だけ呼ばれます。
    /// </summary>
    void Start()
    {
        // アニメーターコンポーネントを取得
        animator = GetComponent<Animator>();
        // Rigidbody2Dコンポーネントを取得
        rb = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// 毎フレーム呼ばれるメソッド
    /// プレイヤーの移動速度を取得し、アニメーションのパラメータを更新します。
    /// </summary>
    void Update()
    {
        // プレイヤーの移動速度を取得
        float speed = Mathf.Abs(Input.GetAxis("Horizontal"));
        // アニメーターに速度を設定
        animator.SetFloat("Speed", speed);

        // 地面に接していないときにジャンプアニメーションを再生
        if (!isGrounded)
        {
            animator.SetBool("IsJumping", true);
        }
        else
        {
            animator.SetBool("IsJumping", false);
        }
    }

    /// <summary>
    /// オブジェクトと衝突したときに呼ばれるメソッド
    /// </summary>
    /// <param name="collision">衝突したオブジェクトの情報</param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 接触したオブジェクトが地面なら
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    /// <summary>
    /// オブジェクトから離れたときに呼ばれるメソッド
    /// </summary>
    /// <param name="collision">離れたオブジェクトの情報</param>
    private void OnCollisionExit2D(Collision2D collision)
    {
        // 離れたオブジェクトが地面なら
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}