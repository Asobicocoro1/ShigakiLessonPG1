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

/*
 了解しました。では、Unityで2Dアニメーションを実装するための異なる方法について、それぞれ詳しく解説します。

### 1. Mecanimアニメーション

#### Mecanimとは
Mecanimは、Unityの標準的なアニメーションシステムで、キャラクターアニメーションの制御に非常に有用です。アニメーターコントローラーを使用して、複数のアニメーションクリップを管理し、ステートマシンを使ってアニメーションの切り替えを制御します。

#### 実装方法
1. **スプライトのインポートと設定**:
   - スプライトシートをインポートし、スプライトを個々に分割します。

2. **アニメーションの作成**:
   - Projectウィンドウで、アニメーションクリップを作成します。各スプライトをドラッグしてAnimationウィンドウに追加します。

3. **アニメーターコントローラーの作成**:
   - Projectウィンドウで、新しいAnimator Controllerを作成します。
   - Animatorウィンドウで、先ほど作成したアニメーションクリップをドラッグしてステートとして追加します。

4. **パラメーターの設定**:
   - AnimatorウィンドウのParametersタブで、新しいパラメーター（例えば、Float型のSpeedやBool型のIsJumping）を追加します。

5. **トランジションの設定**:
   - ステート間のトランジションを設定し、条件としてパラメーターを使用します。

6. **スクリプトでアニメーションを制御**:

```csharp
using UnityEngine;

public class PlayerMecanimController : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float speed = Mathf.Abs(Input.GetAxis("Horizontal"));
        animator.SetFloat("Speed", speed);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, 5f);
        }

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
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
```

### 2. アニメーションツールを使用する（Spine）

#### Spineとは
Spineは、2Dアニメーションを作成するための強力なツールで、骨格アニメーションやデフォーメーションをサポートしています。Spineで作成したアニメーションは、Unity内で使用することができます。

#### 実装方法
1. **Spineでアニメーションを作成**:
   - Spineエディターでキャラクターの骨格アニメーションを作成します。

2. **Unityにインポート**:
   - SpineのUnityプラグインを使用して、SpineプロジェクトをUnityにインポートします。

3. **アニメーション制御**:
   - Spineプラグインを使用して、Unity内でアニメーションを制御します。

```csharp
using Spine.Unity;
using UnityEngine;

public class PlayerSpineController : MonoBehaviour
{
    private SkeletonAnimation skeletonAnimation;
    private Rigidbody2D rb;
    private bool isGrounded;

    void Start()
    {
        skeletonAnimation = GetComponent<SkeletonAnimation>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float speed = Mathf.Abs(Input.GetAxis("Horizontal"));
        skeletonAnimation.AnimationName = speed > 0 ? "walk" : "idle";

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, 5f);
            skeletonAnimation.AnimationName = "jump";
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
```

### 3. シェーダーアニメーション

#### シェーダーアニメーションとは
シェーダーを使用して、エフェクトや特殊なアニメーションを実装します。これにより、波打つ水や炎のエフェクトなど、リアルタイムで変化するアニメーションが可能になります。

#### 実装方法
1. **シェーダーの作成**:
   - UnityのShader Graphを使用して、アニメーションシェーダーを作成します。

2. **マテリアルに適用**:
   - 作成したシェーダーをマテリアルに適用し、そのマテリアルをオブジェクトに割り当てます。

3. **スクリプトから制御**:

```csharp
using UnityEngine;

public class WaterShaderController : MonoBehaviour
{
    private Material material;

    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

    void Update()
    {
        float offset = Time.time * 0.5f;
        material.SetTextureOffset("_MainTex", new Vector2(0, offset));
    }
}
```

### 4. タイムラインアニメーション

#### タイムラインとは
Unityのタイムライン機能を使用して、複雑なカットシーンやイベントアニメーションを作成できます。タイムラインを使用して、キャラクターのアニメーションやオーディオ、カメラの動きなどをシーケンシャルに制御します。

#### 実装方法
1. **タイムラインを作成**:
   - Unityエディターでタイムラインアセットを作成し、シーンに追加します。

2. **トラックを追加**:
   - タイムラインエディターでキャラクターやカメラのトラックを追加し、アニメーションクリップを配置します。

3. **アニメーションの制御**:
   - タイムラインを再生することで、複数のアニメーションを同期して再生します。

```csharp
using UnityEngine;
using UnityEngine.Playables;

public class TimelineController : MonoBehaviour
{
    public PlayableDirector playableDirector;

    void Start()
    {
        // タイムラインを再生
        playableDirector.Play();
    }
}
```

### まとめ

それぞれの方法を以下にまとめます。

1. **Mecanimアニメーション**:
   - Unityの標準的なアニメーションシステムを使用して、複雑なアニメーションを制御。
   - スプライト、アニメーションクリップ、アニメーターコントローラーを使って実装。

2. **アニメーションツール（Spine）**:
   - SpineやDragonBonesなどの外部ツールを使用して、骨格アニメーションやデフォーメーションを作成。
   - Unityプラグインを使って、アニメーションをインポートし、制御。

3. **シェーダーアニメーション**:
   - シェーダーを使って、特殊なエフェクトやリアルタイムで変化するアニメーションを実装。
   - Shader Graphを使用してシェーダーを作成し、スクリプトからパラメーターを制御。

4. **タイムラインアニメーション**:
   - Unityのタイムライン機能を使用して、カットシーンやイベントアニメーションをシーケンシャルに制御。
   - タイムラインアセットを作成し、トラックを追加してアニメーションを配置。

これらの方法を適宜組み合わせることで、より豊かな2DアニメーションをUnityで実現することができます。ゲームの内容や必要な演出に応じて最適な方法を選択してください。
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
