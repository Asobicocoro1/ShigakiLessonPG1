using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 ### Chapter 4: UIと監督オブジェクト (4-3から)

#### 4-3 シーンにオブジェクトを配置しよう
- **4-3-1 地面の配置**
  - Unityエディタを開き、シーンビューに地面オブジェクトを配置します。
  - 地面オブジェクトを3Dオブジェクト（Plane）として作成し、適切な位置とスケールに設定します。

- **4-3-2 車の配置**
  - 地面オブジェクトの上に車のオブジェクトを配置します。
  - 3Dモデルや2Dスプライトをインポートし、シーンにドラッグ＆ドロップします。
  - 車オブジェクトの位置や回転を調整して、地面の上に配置します。

- **4-3-3 旗の配置**
  - ゴール地点として旗のオブジェクトを配置します。
  - 3Dモデルや2Dスプライトを使用し、適切な位置に配置します。

- **4-3-4 背景色を変更する**
  - シーンの背景色を変更して、視覚的な魅力を向上させます。
  - カメラの背景色を設定する方法を学びます。

- **4-3-5 スプライトレンダーの設定**
  - 2Dスプライトオブジェクトを使用する場合、スプライトレンダラーの設定を行います。
  - スプライトレンダラーを使って画像をシーンに表示し、色や描画順序を設定します。

#### 講義内容の詳細

##### 4-3-1 地面の配置
1. **地面オブジェクトの作成**
   - メニューから「GameObject」 > 「3D Object」 > 「Plane」を選択します。
   - 「Plane」の位置を (0, 0, 0) に設定し、スケールを適切に調整します（例: x=10, y=1, z=10）。

2. **地面のマテリアル設定**
   - プロジェクトウィンドウで右クリックし、「Create」 > 「Material」を選択。
   - 新しいマテリアルを作成し、色やテクスチャを設定して「Plane」にアタッチします。

##### 4-3-2 車の配置
1. **車オブジェクトのインポート**
   - プロジェクトウィンドウで右クリックし、「Import New Asset」を選択。
   - 車の3Dモデルや2Dスプライトをインポートします。

2. **車オブジェクトの配置**
   - インポートした車オブジェクトをシーンにドラッグ＆ドロップします。
   - 車の位置を (0, 0.5, 0) に設定し、回転やスケールを調整します。

##### 4-3-3 旗の配置
1. **旗オブジェクトのインポート**
   - 車と同様に、旗の3Dモデルや2Dスプライトをインポートします。

2. **旗オブジェクトの配置**
   - インポートした旗オブジェクトをシーンにドラッグ＆ドロップします。
   - 旗の位置をゴール地点に設定します（例: (0, 0.5, 5)）。

##### 4-3-4 背景色を変更する
1. **カメラの背景色設定**
   - シーンビューのカメラを選択します。
   - インスペクターウィンドウで「Background」プロパティを見つけ、希望する色に変更します。

##### 4-3-5 スプライトレンダーの設定
1. **スプライトオブジェクトの作成**
   - メニューから「GameObject」 > 「2D Object」 > 「Sprite」を選択。
   - インポートしたスプライト画像をスプライトレンダラーに設定します。

2. **スプライトレンダラーの設定**
   - インスペクターウィンドウでスプライトレンダラーコンポーネントを見つけ、以下のプロパティを設定します。
     - **Sprite**: 使用するスプライト画像を設定します。
     - **Color**: スプライトの色を設定します（必要に応じて）。
     - **Order in Layer**: スプライトの描画順序を設定し、他のオブジェクトとの前後関係を調整します。
### Chapter 4: UIと監督オブジェクト (4-4から)

#### 4-4 スワイプで車を動かす方法を考えよう

**目標**: スワイプ入力に応じて車を動かすスクリプトを作成し、車オブジェクトにアタッチして、スワイプの長さに応じた車の移動距離を調整します。

##### 4-4-1 車のスクリプトを作る
1. **新しいスクリプトの作成**
   - プロジェクトウィンドウで右クリックし、「Create」 > 「C# Script」を選択。
   - スクリプト名を「CarController」とします。
2. **スクリプトの編集**
   - 「CarController.cs」スクリプトをダブルクリックして、Visual Studioやエディタで開きます。
   - 以下のコードを入力します。

```csharp
using UnityEngine;

public class CarController : MonoBehaviour
{
    private Vector2 startTouchPosition;
    private Vector2 endTouchPosition;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                startTouchPosition = touch.position;
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                endTouchPosition = touch.position;
                MoveCar();
            }
        }
    }

    void MoveCar()
    {
        Vector2 swipeVector = endTouchPosition - startTouchPosition;
        float swipeDistance = swipeVector.magnitude;

        Vector2 direction = swipeVector.normalized;
        rb.AddForce(direction * swipeDistance);
    }
}
```

##### 4-4-2 スクリプトを車オブジェクトにアタッチする
1. **車オブジェクトの選択**
   - シーンビューまたはヒエラルキーウィンドウで車オブジェクトを選択します。
2. **スクリプトのアタッチ**
   - インスペクターウィンドウの「Add Component」をクリックし、「CarController」を検索して追加します。

##### 4-4-3 スワイプの長さに応じて車の移動距離を変える
1. **スクリプトの調整**
   - スクリプト内の`AddForce`メソッドの引数を調整して、スワイプの長さに応じた移動距離を設定します。
   - 必要に応じて、移動距離の係数を追加して調整します。

```csharp
void MoveCar()
{
    Vector2 swipeVector = endTouchPosition - startTouchPosition;
    float swipeDistance = swipeVector.magnitude;

    Vector2 direction = swipeVector.normalized;
    float moveDistance = swipeDistance * 0.1f; // 移動距離の係数を追加

    rb.AddForce(direction * moveDistance, ForceMode2D.Impulse);
}
```

### 講義内容の詳細CarController ,MoveCar

#### 4-4-1 車のスクリプトを作る
1. **新しいスクリプトの作成**
   - プロジェクトウィンドウで右クリックし、「Create」 > 「C# Script」を選択し、「CarController」と名付けます。

2. **スクリプトの編集**
   - ダブルクリックしてスクリプトを開き、スワイプ入力を処理し、車を動かすコードを入力します。

#### 4-4-2 スクリプトを車オブジェクトにアタッチする
1. **車オブジェクトの選択**
   - シーンビューまたはヒエラルキーウィンドウで車オブジェクトを選択します。

2. **スクリプトのアタッチ**
   - インスペクターウィンドウで「Add Component」をクリックし、「CarController」を検索して追加します。

#### 4-4-3 スワイプの長さに応じて車の移動距離を変える
1. **スクリプトの調整**
   - `MoveCar`メソッドの`AddForce`呼び出しに移動距離の係数を追加し、スワイプの長さに応じて車の移動距離を調整します。





#
 */
public class Chapter4Guide : MonoBehaviour
{
 
}
