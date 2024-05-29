using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*


### 講義4: キー操作でプレイヤを動かそう（2Dゲーム編）

#### プレイヤのスクリプトを作る
- **キー操作でプレイヤを動かすスクリプトを作成しよう**
  - プレイヤを動かすためには、スクリプト（プログラム）が必要です。
  - Unityの「プロジェクト」ウィンドウで、右クリックして「Create（作成）」→「C# Script」を選びます。
  - スクリプトに「PlayerController」という名前を付けます。

- **スクリプトの内容**
  - スクリプトをダブルクリックして、Visual Studio（または他のコードエディタ）で開きます。
  - 以下のコードをスクリプトに書きます：

```csharp
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // プレイヤの移動速度を設定します
    public float speed = 5f;

    void Update()
    {
        // 横方向の入力を取得します（矢印キーの左右やAとDキー）
        float moveHorizontal = Input.GetAxis("Horizontal");
        // 縦方向の入力を取得します（矢印キーの上下やWとSキー）
        float moveVertical = Input.GetAxis("Vertical");

        // 移動する方向を決めます。横方向の入力と縦方向の入力を使います。
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        // プレイヤを移動させます。
        // movementの方向にspeedの速さで、時間に合わせて移動します。
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
```

- **日本語解説付きのスクリプトの説明**
  - `public float speed = 5f;`  
    - プレイヤの移動速度を設定します。例えば、5fとすると、速さが5のスピードで動きます。

  - `void Update()`  
    - `Update`メソッドは、ゲームのフレームごとに呼び出されます。つまり、1秒間に何回も実行されます。

  - `float moveHorizontal = Input.GetAxis("Horizontal");`  
    - `Input.GetAxis("Horizontal")`は、キーボードの左右の矢印キーやAとDキーの入力を取得します。例えば、右矢印キーを押すと1、左矢印キーを押すと-1の値を返します。

  - `float moveVertical = Input.GetAxis("Vertical");`  
    - `Input.GetAxis("Vertical")`は、キーボードの上下の矢印キーやWとSキーの入力を取得します。例えば、上矢印キーを押すと1、下矢印キーを押すと-1の値を返します。

  - `Vector2 movement = new Vector2(moveHorizontal, moveVertical);`  
    - `Vector2`は2次元のベクトル（方向）を表します。ここでは、横方向（X軸）と縦方向（Y軸）の入力を使って、プレイヤの移動方向を決めています。

  - `transform.Translate(movement * speed * Time.deltaTime);`  
    - `transform.Translate`は、オブジェクトを指定した方向に移動させるメソッドです。`movement`の方向に、`speed`の速さで、`Time.deltaTime`（1フレームの時間）を掛けて移動します。

#### プレイヤのスクリプトをアタッチする
- **スクリプトをプレイヤオブジェクトにアタッチしよう**
  - Unityに戻って、「ヒエラルキー」ウィンドウでプレイヤオブジェクト（例えば2Dのスプライト）を選びます。
  - 「インスペクター」ウィンドウで「Add Component（コンポーネントを追加）」ボタンをクリックし、「PlayerController」スクリプトを選びます。
  - これでスクリプトがプレイヤオブジェクトにアタッチされ、キー操作で動かせるようになります。

#### まとめ
- プレイヤオブジェクトにスクリプトをアタッチし、キー操作で動かせるようにすることで、ゲームの基本的な操作ができるようになります。これからは、プレイヤをもっと面白く動かす方法を学びます。

これで、講義4の内容がわかりやすくなったかな？分からないところがあったら、気軽に質問してね！
 */
public class Lecture4 : MonoBehaviour
{
   
}
