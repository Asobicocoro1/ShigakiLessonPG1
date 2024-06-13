using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 ジャンプアニメーションの発動条件を「地面に接触していないとき」に設定するには、`IsJumping`パラメーターの設定とTransitionの条件を適切に調整する必要があります。以下に具体的な手順を説明します。

### Animatorの設定

#### 1. パラメーターの設定
- `IsJumping`パラメーターが正しくBool型であることを確認します。

#### 2. Transitionの条件設定
**IdleからJumpへのTransition**:
1. Idleステートを右クリックし、「Make Transition」を選択してJumpステートへの矢印をドラッグします。
2. 矢印をクリックして、Inspectorウィンドウで「Conditions」を設定します。
   - Condition: IsJumping == true
   - 「Has Exit Time」のチェックボックスをオフにします。

**JumpからIdleへのTransition**:
1. Jumpステートを右クリックし、「Make Transition」を選択してIdleステートへの矢印をドラッグします。
2. 矢印をクリックして、Inspectorウィンドウで「Conditions」を設定します。
   - Condition: IsJumping == false
   - 「Has Exit Time」のチェックボックスをオフにします。

### スクリプトの設定

#### PlayerAnimationControllerスクリプトの修正
ジャンプアニメーションが「地面に接触していないとき」に発動するように、`IsJumping`パラメーターを設定します。

```csharp
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
        float speed = Mathf.Abs(Input.GetAxis("Horizontal"));
        // アニメーターに速度を設定
        animator.SetFloat("Speed", speed);

        // ジャンプ入力を検知し、地面に接している場合にジャンプ
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, 5f); // ジャンプ力を設定
        }

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
```

### デバッグ
**Debug.Logを使用して状態を確認**:
- `Update`メソッドと`OnCollisionEnter2D`、`OnCollisionExit2D`メソッドに`Debug.Log`を追加して、パラメーターが正しく変更されているか確認します。

```csharp
void Update()
{
    float speed = Mathf.Abs(Input.GetAxis("Horizontal"));
    animator.SetFloat("Speed", speed);

    if (Input.GetButtonDown("Jump") && isGrounded)
    {
        rb.velocity = new Vector2(rb.velocity.x, 5f);
        Debug.Log("Jumping");
    }

    if (!isGrounded)
    {
        animator.SetBool("IsJumping", true);
        Debug.Log("In Air");
    }
    else
    {
        animator.SetBool("IsJumping", false);
        Debug.Log("Grounded");
    }
}

private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Ground"))
    {
        isGrounded = true;
        Debug.Log("On Ground");
    }
}

private void OnCollisionExit2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Ground"))
    {
        isGrounded = false;
        Debug.Log("Off Ground");
    }
}
```

これにより、プレイヤーが地面に接触していないときにジャンプアニメーションが正しく再生されるようになります。Transitionの条件とスクリプトの設定を確認し、アニメーションが正しく切り替わることを確認してください。
 */

public class Guide_Animator : MonoBehaviour
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
