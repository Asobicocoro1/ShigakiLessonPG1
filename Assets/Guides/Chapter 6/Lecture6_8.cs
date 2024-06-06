using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 ### 講義8: シーン遷移の基本概念と実装（6-10 シーン間の遷移方法を学ぼう）

#### 学習の目的の明確化 (1分)
**説明**: シーン間の遷移方法を学び、ゲームクリア時のシーンを作成します。シーン遷移の方法を実装し、代表的なバグの対処方法も学びます。

#### 講義 (20分)
**内容**: シーン遷移の基本概念と実装（6-10 シーン間の遷移方法を学ぼう）

##### 6-10-1 シーン遷移の概要
- **説明**: シーン遷移は、現在のシーンから別のシーンに移動することを指します。Unityでは、`SceneManager.LoadScene`メソッドを使用してシーンを切り替えます。

##### 6-10-2 クリアシーンを作成する
- **手順**:
  1. Hierarchyウィンドウで「Create」→「Scene」を選択します。
  2. 新しいシーンの名前を「ClearScene」に変更します。
  3. シーンに「クリアおめでとう！」などのテキストを表示するUI要素を追加します。
  4. シーンを保存します（File → Save Scene）。

##### 6-10-3 「クリアシーン」から「ゲームシーン」に遷移する
- **手順**:
  1. ClearSceneに新しいボタンを追加します（GameObject → UI → Button）。
  2. ボタンに「再挑戦」などのテキストを設定します。
  3. ボタンの`OnClick`イベントにスクリプトを追加し、ゲームシーンに遷移させます。

```csharp
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearSceneController : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
```

##### 6-10-4 シーンを登録する
- **手順**:
  1. File → Build Settingsを開きます。
  2. 「Scenes in Build」に現在のゲームシーン（例：GameScene）とクリアシーン（ClearScene）をドラッグ＆ドロップして追加します。

##### 6-10-5 「ゲームシーン」から「クリアシーン」に遷移する
- **手順**:
  1. 以前に作成したGoalFlagスクリプトを以下のように修正します。

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
            // クリアシーンに遷移
            SceneManager.LoadScene("ClearScene");
        }
    }
}
```

##### 6-10-6 バグをなくそう
- **説明**: シーン遷移の際に発生する可能性のあるバグを防ぐための対策を講じます。例えば、遷移中にオブジェクトが重複して生成される問題を防ぐために、適切なオブジェクト管理を行います。

### Unity上で個人操作 (10分)
- **内容**: シーン遷移を実装し、バグを修正する
  - ClearSceneを作成し、再挑戦ボタンを追加します。
  - シーンをBuild Settingsに登録し、GoalFlagスクリプトを修正してシーン遷移を実装します。
  - ゲームを実行し、シーン遷移が正しく行われるか確認します。

### 生徒同士で説明 (10分)
- **内容**: 学んだことを互いに説明し合い、理解を深める
  - 各自がどのようにシーン遷移を実装したか、クリアシーンを作成したかを説明し合います。
  - シーン遷移の際に発生する可能性のあるバグとその対処法について意見を交換します。

これで、シーン遷移の基本概念と実装方法を学びました。次の講義では、スマートフォンでの操作に対応する設定とビルド方法について学びます。
 */
public class Lecture6_8 : MonoBehaviour
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
