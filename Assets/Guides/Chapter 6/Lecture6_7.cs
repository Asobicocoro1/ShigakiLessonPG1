using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 ### 講義7: Physicsを使った当たり判定（6-9 Physicsを使った当たり判定を学ぼう）

#### 学習の目的の明確化 (1分)
**説明**: Physicsを使った当たり判定とシーン間の遷移方法を学びます。衝突検出とシーン遷移の実装を通じて、ゲームの進行を制御する技術を身につけます。

#### 講義 (20分)
**内容**: 当たり判定の実装（6-9 Physicsを使った当たり判定を学ぼう）

##### 6-9-1 Physicsで衝突を検出する
- **説明**: Physicsエンジンを使って、オブジェクト同士が衝突したときの処理を実装します。Rigidbody 2DとCollider 2Dを使用して、物理演算に基づく衝突判定を行います。

##### 6-9-2 プレイヤと旗の当たり判定を作る
- **手順**:
  1. Projectウィンドウで「Scripts」フォルダを開きます。
  2. 「Scripts」フォルダ内で右クリックし、「Create」→「C# Script」を選択し、スクリプト名を「GoalFlag」にします。
  3. GoalFlagスクリプトをダブルクリックして開き、以下のコードを入力します。

```csharp
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// ゴールの旗に触れたときの処理を管理するスクリプト
/// </summary>
public class GoalFlag : MonoBehaviour
{
    /// <summary>
    /// プレイヤーが旗に触れたときに呼ばれるメソッド
    /// </summary>
    /// <param name="collision">衝突したオブジェクトの情報</param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // もし衝突したオブジェクトがプレイヤーなら
        if (collision.gameObject.CompareTag("Player"))
        {
            // 次のシーンに遷移
            SceneManager.LoadScene("NextSceneName");
        }
    }
}
```

##### 6-9-3 プレイヤにタグを設定する
- **手順**:
  1. Hierarchyウィンドウでプレイヤオブジェクトを選択します。
  2. Inspectorウィンドウで、Tagドロップダウンメニューから「Player」を選択します。プレイヤオブジェクトに「Player」タグを設定します。

##### 6-9-4 旗にCollider 2Dとスクリプトをアタッチする
- **手順**:
  1. HierarchyウィンドウでGoalFlagオブジェクトを選択します。
  2. Inspectorウィンドウで「Add Component」をクリックし、「Box Collider 2D」を選択します。
  3. GoalFlagオブジェクトに「GoalFlag」スクリプトをアタッチします。

### Unity上で個人操作 (10分)
- **内容**: プレイヤと旗の当たり判定を作成する
  - GoalFlagスクリプトを作成し、GoalFlagオブジェクトにアタッチします。
  - プレイヤに「Player」タグを設定し、旗にBox Collider 2DとGoalFlagスクリプトをアタッチします。
  - ゲームを実行し、プレイヤが旗に触れたときにシーンが遷移するか確認します。

### 生徒同士で説明 (10分)
- **内容**: 学んだことを互いに説明し合い、理解を深める
  - 各自がどのようにGoalFlagスクリプトを作成し、当たり判定を実装したかを説明し合います。
  - シーン遷移の方法やスクリプトの役割について意見を交換します。

これで、Physicsを使った当たり判定とシーン遷移の実装方法を学びました。次の講義では、シーン遷移の基本概念と実装についてさらに詳しく学びます。
 */
public class Lecture6_7 : MonoBehaviour
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
