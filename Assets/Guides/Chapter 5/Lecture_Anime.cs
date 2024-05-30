using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
了解しました。以下に、情報を整理して、プレイヤーにアニメーションを追加し、スクリプトでコントロールする手順を詳細に説明します。

### アニメーションの設定手順

### 1. Unityに画像をインポートする

1. **画像のインポート**
   - Unityを開きます。
   - プロジェクトウィンドウで「Assets」フォルダを右クリックし、「Import New Asset...（新しいアセットのインポート）」を選びます。
   - 4枚の歩行画像を選択して「Import（インポート）」をクリックします。

### 2. スプライトシートの設定

1. **スプライトの設定**
   - インポートした画像の1つを選択します。
   - インスペクターウィンドウで「Sprite Mode（スプライトモード）」を「Single（単一）」に設定します。
   - 「Apply（適用）」をクリックします。

### 3. アニメーションクリップの作成

1. **アニメーションウィンドウを開く**
   - メニューから「Window（ウィンドウ）」 > 「Animation（アニメーション）」 > 「Animation（アニメーション）」を選択して、アニメーションウィンドウを開きます。

2. **新しいアニメーションクリップを作成**
   - シーンウィンドウで、歩行アニメーションをつけたいオブジェクトを選択します。オブジェクトがない場合、2Dオブジェクト（例: スプライト）をシーンにドラッグ＆ドロップして配置します。
   - アニメーションウィンドウで「Create（作成）」ボタンをクリックし、アニメーションクリップに「WalkRight」と名前を付けて保存します。

3. **フレームにスプライトを追加**
   - インポートした4枚の歩行画像をプロジェクトウィンドウからアニメーションウィンドウにドラッグ＆ドロップして、アニメーションの各フレームに設定します。

### 4. Animator Controllerの設定

1. **Animator Controllerを作成**
   - プロジェクトウィンドウで右クリックし、「Create（作成）」 > 「Animator Controller（アニメーターコントローラ）」を選びます。
   - 「PlayerAnimatorController」と名前を付けて保存します。

2. **Animator Controllerにアニメーションクリップを追加**
   - 作成した「PlayerAnimatorController」をダブルクリックして、Animatorウィンドウを開きます。
   - プロジェクトウィンドウから「WalkRight」アニメーションクリップをAnimatorウィンドウにドラッグ＆ドロップします。

3. **Animator Controllerを設定**
   - シーンウィンドウでプレイヤーオブジェクトを選択します。
   - インスペクターウィンドウで「Add Component（コンポーネントを追加）」ボタンをクリックし、「Animator（アニメーター）」を選びます。
   - 「Controller（コントローラー）」フィールドに、「PlayerAnimatorController」をドラッグ＆ドロップします。

### 5. PlayerControllerスクリプトの設定

1. **スクリプトにAnimatorを追加**
   - プレイヤーオブジェクトにアタッチされているスクリプトに、Animatorを制御するコードを追加します。

### 6. アニメーションの条件を設定

1. **Animatorウィンドウで条件を設定**
   - Animatorウィンドウで「WalkRight」アニメーションを選択し、右クリックして「Make Transition（遷移を作成）」を選びます。
   - 「Any State（任意の状態）」から「WalkRight」への遷移を作成します。
   - 遷移の条件として、パラメーター「isWalking」を`true`に設定します。
   - 「WalkRight」から「Idle（待機）」への遷移も作成し、条件として「isWalking」を`false`に設定します。

### パラメーターの作成と設定手順

1. **パラメーターの作成**
   - Unityのメニューから「Window（ウィンドウ）」>「Animation（アニメーション）」>「Animator（アニメーター）」を選択して、Animatorウィンドウを開きます。
   - Animatorウィンドウの左側に「Parameters（パラメーター）」タブがあります。このタブをクリックします。
   - パラメータータブの下部にある「+」ボタンをクリックし、「Bool（ブール）」を選択します。
   - パラメーターに「isWalking」という名前を付けます。

2. **遷移の作成と条件の設定**
   - プレイヤーオブジェクトを選択し、Animatorウィンドウに「WalkRight」アニメーションクリップが表示されていることを確認します。
   - 「Any State」を右クリックし、「Make Transition（遷移を作成）」を選びます。
   - 矢印をドラッグして「WalkRight」に接続します。
   - 作成した遷移（矢印）をクリックすると、インスペクターウィンドウに遷移の設定が表示されます。
   - インスペクターウィンドウの「Conditions（条件）」セクションで「+」ボタンをクリックして、新しい条件を追加します。
   - ドロップダウンリストから「isWalking」を選択し、その値を`true`に設定します。
   - 同様に、遷移元の状態（「WalkRight」）から通常の待機状態（「Idle」）への遷移を作成します。
   - 作成した遷移をクリックし、インスペクターウィンドウの「Conditions（条件）」セクションで「+」ボタンをクリックして、新しい条件を追加します。
   - ドロップダウンリストから「isWalking」を選択し、その値を`false`に設定します。

### 更新された PlayerController スクリプト

```csharp
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
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
        if (gameManager != null)
        {
            gameManager.UpdateHP(currentHP); // HPゲージを更新
        }
        else
        {
            Debug.LogError("GameManager is not assigned!");
        }
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
```

これで、プレイヤーが左右に移動するときにアニメーションが再生され、向きも適切に反転されます。分からないところがあれば、気軽に聞いてくださいね！ */

public class Lecture_Anime : MonoBehaviour
{

}
