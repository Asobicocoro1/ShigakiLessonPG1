﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 ### 講義4: アニメーションの基本概念（6-6 アニメーションについて学ぼう）

#### 学習の目的の明確化 (1分)
**説明**: アニメーションを使ってキャラクターやオブジェクトに動きを与えます。基本的なAnimation Clipの作成と適用、アニメーション速度の調節を学びます。

#### 講義 (20分)
**内容**: アニメーションの基本概念（6-6 アニメーションについて学ぼう）

##### 6-6-1 Unityのアニメーション
- **説明**: Unityのアニメーションシステムは、オブジェクトのプロパティを時間経過に合わせて変化させることで、動きを作り出します。

##### 6-6-2 Mecanimとは
- **説明**: MecanimはUnityのアニメーションシステムで、視覚的なアニメーションコントローラーを使って複雑なアニメーションを簡単に管理できます。

##### 6-6-3 Animation Clipを作る
- **手順**:
  1. Projectウィンドウで「Animations」フォルダを作成します。
  2. Hierarchyウィンドウでアニメーションを適用するオブジェクト（例：プレイヤー）を選択します。
  3. ウィンドウ上部の「Window」→「Animation」→「Animation」を選択してAnimationウィンドウを開きます。
  4. 「Create」ボタンをクリックし、新しいAnimation Clipを作成します。名前を「PlayerWalk」にします。
  5. Animationウィンドウでアニメーションのフレームを設定します。例えば、キャラクターの歩行アニメーションを作成します。

##### 6-6-4 歩行アニメーションを作る
- **手順**:
  1. Animationウィンドウで、各フレームに対応するキャラクターのポーズを設定します。
  2. 必要なフレーム数を設定し、ループするアニメーションを作成します。

##### 6-6-5 アニメーションの速度を調節する
- **手順**:
  1. Animationウィンドウで「Samples」フィールドを調整し、アニメーションの速度を変更します。
  2. 実際に再生してみて、アニメーションの速度を確認し、適切な速度に調整します。

### Unity上で個人操作 (10分)
- **内容**: Animation Clipを作成し、歩行アニメーションを作成する
  - Animationウィンドウを使って、プレイヤーの歩行アニメーションを作成します。
  - 作成したAnimation Clipを適用し、アニメーションの速度を調整します。

### 生徒同士で説明 (10分)
- **内容**: 学んだことを互いに説明し合い、理解を深める
  - 各自がどのようにAnimation Clipを作成し、アニメーションを設定したかを説明し合います。
  - アニメーションの設定方法や速度の調整について意見を交換します。

これで、アニメーションの基本概念に関する講義は終了です。次の講義では、ステージの作成について学びます。

### 講義6-4: アニメーターの使い方を学ぼう

#### 学習の目的の明確化 (1分)
**説明**: Unityのアニメーターの使い方を学び、キャラクターにアニメーションを適用する方法を理解します。アニメーターを使用すると、複数のアニメーションを管理し、スムーズに切り替えることができます。

#### 講義 (20分)
**内容**: アニメーターの使い方（6-4 アニメーターについて学ぼう）

##### 6-4-1 アニメーターの基本
- **説明**: アニメーターは、キャラクターに複数のアニメーションを適用し、アニメーションの切り替えを管理するツールです。例えば、キャラクターが歩く、ジャンプする、止まるなどのアニメーションを管理できます。

##### 6-4-2 アニメーションの設定
- **手順**:
  1. **アニメーターコントローラーの作成**
     - Projectウィンドウで「Create」→「Animator Controller」を選択します。
     - 新しいアニメーターコントローラーに名前を付けます（例：「PlayerAnimator」）。

  2. **アニメーションのインポート**
     - 歩行アニメーション、ジャンプアニメーションなど、必要なアニメーションファイルをUnityにインポートします。

##### 6-4-3 アニメーターウィンドウの使い方
- **手順**:
  1. **アニメーターウィンドウを開く**
     - アニメーターコントローラーをダブルクリックすると、アニメーターウィンドウが開きます。

  2. **アニメーションステートの追加**
     - アニメーターウィンドウで右クリックし、「Create State」→「Empty」を選択します。
     - ステートに名前を付けます（例：「Walk」）。
     - インポートした歩行アニメーションをステートにドラッグ＆ドロップします。

  3. **トランジションの設定**
     - 「Walk」ステートを右クリックし、「Make Transition」を選択します。
     - 新しいステートを作成し（例：「Idle」）、トランジションの矢印をこの新しいステートにドラッグします。
     - 同様に、インポートしたアイドルアニメーションを新しいステートにドラッグ＆ドロップします。

##### 6-4-4 条件付きトランジションの設定
- **手順**:
  1. **パラメーターの設定**
     - アニメーターウィンドウの左側にある「Parameters」タブを選択します。
     - 「+」ボタンをクリックし、「Float」や「Bool」などのパラメーターを追加します（例：「Speed」）。

  2. **トランジションに条件を設定**
     - トランジションの矢印をクリックし、「Conditions」セクションを開きます。
     - 追加したパラメーター（例：「Speed」）に基づいて条件を設定します。
     - 例えば、「Speed」が0より大きい場合に「Walk」ステートに遷移するように設定します。

##### 6-4-5 スクリプトからアニメーションを制御
- **手順**:
  1. **スクリプトの作成**
     - Projectウィンドウで「Scripts」フォルダを開きます。
     - 新しいスクリプトを作成し、「PlayerAnimationController」に名前を付けます。
     - スクリプトを開き、以下のコードを入力します。

```csharp
using UnityEngine;

/// <summary>
/// プレイヤーのアニメーションを制御するスクリプト
/// </summary>
public class PlayerAnimationController : MonoBehaviour
{
    // アニメーターコンポーネントへの参照
    private Animator animator;
    // プレイヤーの移動速度
    private float speed;

    void Start()
    {
        // アニメーターコンポーネントを取得
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // プレイヤーの移動速度を計算
        speed = Mathf.Abs(Input.GetAxis("Horizontal"));
        // アニメーターに速度を設定
        animator.SetFloat("Speed", speed);
    }
}
```

- **手順**:
  1. **スクリプトをプレイヤにアタッチ**
     - Hierarchyウィンドウでプレイヤオブジェクトを選択します。
     - Inspectorウィンドウで「Add Component」をクリックし、「PlayerAnimationController」スクリプトをアタッチします。

### Unity上で個人操作 (10分)
- **内容**: アニメーターを設定し、アニメーションを適用する
  - アニメーターコントローラーを作成し、アニメーションステートを追加します。
  - 条件付きトランジションを設定し、スクリプトからアニメーションを制御します。
  - ゲームを実行し、アニメーションが正しく再生されるか確認します。

### 生徒同士で説明 (10分)
- **内容**: 学んだことを互いに説明し合い、理解を深める
  - 各自がどのようにアニメーターコントローラーを設定し、アニメーションを適用したかを説明し合います。
  - アニメーションの制御方法やスクリプトの役割について意見を交換します。

これで、Unityのアニメーターの使い方とアニメーションの適用方法を学びました。次の講義では、ステージの作成について学びます。
 */
public class Lecture6_4 : MonoBehaviour
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