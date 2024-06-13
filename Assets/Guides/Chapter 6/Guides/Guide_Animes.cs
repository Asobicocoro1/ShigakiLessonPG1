using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 了解しました。では、Unityで2Dアニメーションを実装する3つの方法について、小学生にもわかりやすく、詳細に説明します。

### 1. Mecanimアニメーション

#### Mecanimとは？
Mecanim（メカニム）は、Unityの中にあるアニメーションシステムです。これは、キャラクターが歩いたり、走ったり、ジャンプしたりする動きを作るために使います。Mecanimを使うと、いろいろな動きを簡単に切り替えることができます。

#### 実装方法

1. **スプライトの準備**
   - ゲームのキャラクターの動きを作るために、キャラクターがいろんなポーズをとった絵（スプライト）を用意します。
   - 例えば、歩いているポーズ、ジャンプしているポーズ、止まっているポーズなどの絵をたくさん描きます。

2. **スプライトをUnityに取り込む**
   - 用意したスプライトをUnityに取り込みます。これは、スプライトの画像ファイルをUnityの「Assets」フォルダにドラッグ＆ドロップするだけです。

3. **スプライトシートの設定**
   - もし、スプライトが一枚の大きな絵（スプライトシート）になっている場合、それを分割する必要があります。
   - Unityでスプライトシートを選んで、「Sprite Mode」を「Multiple」に設定し、「Sprite Editor」でスプライトを個々の絵に分割します。

4. **アニメーションクリップの作成**
   - スプライトを使ってアニメーションを作ります。
   - Unityの「Animation」ウィンドウで、新しいアニメーションクリップを作成し、スプライトをドラッグ＆ドロップしてアニメーションを作ります。
   - 例えば、「Idle」というアニメーションクリップを作り、キャラクターが止まっているアニメーションを作成します。

5. **アニメーターコントローラーの作成**
   - 「Animator Controller」を作成し、これをキャラクターに設定します。
   - 「Animator」ウィンドウで、アニメーションクリップをドラッグ＆ドロップしてステート（状態）として追加します。
   - 例えば、「Idle」ステートと「Walk」ステートを作成します。

6. **パラメーターの追加**
   - 「Animator」ウィンドウの「Parameters」タブで、アニメーションを切り替えるためのパラメーターを追加します。
   - 例えば、Float型の「Speed」やBool型の「IsJumping」を追加します。

7. **トランジションの設定**
   - ステート間のトランジション（遷移）を設定します。
   - 例えば、「Idle」ステートから「Walk」ステートへのトランジションを作成し、「Speed」が0.1より大きくなったら「Walk」ステートに遷移するように設定します。

8. **スクリプトでアニメーションを制御**

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

### 3. シェーダーアニメーション

#### シェーダーアニメーションとは？
シェーダーアニメーションは、キャラクターやオブジェクトに対して特別な効果を付けるための方法です。例えば、水が波打つような動きや、炎が燃えるような動きを作ることができます。シェーダーを使うと、これらの動きをスムーズに実現できます。

#### 実装方法

1. **シェーダーの作成**
   - Unityの「Shader Graph」を使用して、アニメーションシェーダーを作成します。
   - Shader Graphを使うと、ノードという部品をつなげることでシェーダーを作ることができます。

2. **マテリアルの作成**
   - 作成したシェーダーを使って新しいマテリアルを作成します。
   - マテリアルは、オブジェクトの表面に貼り付ける色や質感のことです。

3. **オブジェクトにマテリアルを適用**
   - マテリアルをオブジェクトに適用します。これにより、そのオブジェクトにシェーダーの効果が適用されます。

4. **スクリプトからシェーダーを制御**
   - スクリプトを使って、シェーダーのパラメーターを変更し、アニメーションを制御します。

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

このスクリプトは、水のシェーダーが時間とともに動くように設定しています。`Time.time` はゲームの開始から経過した時間を示しており、これを使ってシェーダーの動きを制御します。

### 4. タイムラインアニメーション

#### タイムラインアニメーションとは？
タイムラインアニメーションは、Unityのタイムライン機能を使ってキャラクターやカメラの動きを制御する方法です。これは、映画のシーンのように、複数のアクションを連続して再生するのに適しています。

#### 実装方法

1. **タイムラインを作成**
   - Unityの「Timeline」ウィンドウで、新しいタイムラインアセットを作成します。
   - タイムラインアセットは、シーンの中でどのようなアクションが起こるかを定義するファイルです。

2. **トラックを追加**
   - タイムラインにトラックを追加します。トラックは、特定のオブジェクト（例えばキャラクターやカメラ）の動きを定義します。
   - 例えば、キャラクターが歩くトラック、カメラが移動するトラックなどを追加します。

3. **アニメーションクリップを配置**
   - 各トラックにアニメーションクリップを配置します。アニメーションクリップは、特定の時間にどのような動きが起こるかを示します。
   - 例えば、0秒から2秒まではキャラクターが歩き、2秒から4秒まではキャラクターがジャンプする、といった設定を行います。

4. **タイムラインの再生**
   - タイムラインアセットをシーンに追加し、再生します。
   - タイムラインの再生は、`PlayableDirector`コンポーネントを使って制御します。

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

このスクリプトは、`PlayableDirector`コンポーネントを使って、ゲームが開始したときにタイムラインを再生します。

### まとめ

1. **Mecanimアニメーション**:
   - Unityの標準的なアニメーションシステムを使用して、複数の動きを切り替える方法です。
   - スプライト、アニメーションクリップ、アニメーターコントローラーを使って実装します。

2. **シェーダーアニメーション**:
   - シェーダーを使って、特別なエフェクトや

動きを作る方法です。
   - Shader Graphを使ってシェーダーを作成し、スクリプトからパラメーターを変更してアニメーションを制御します。

3. **タイムラインアニメーション**:
   - Unityのタイムライン機能を使って、シーンの中で複数のアクションを連続して再生する方法です。
   - タイムラインアセット、トラック、アニメーションクリップを使って実装します。

それぞれの方法を使って、ゲームに豊かな動きを追加しましょう。ゲームの内容や必要な演出に応じて最適な方法を選んでください。
 */

public class Guide_Animes : MonoBehaviour
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
