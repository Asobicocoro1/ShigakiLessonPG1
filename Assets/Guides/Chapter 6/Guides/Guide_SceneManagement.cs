using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 `UnityEngine.SceneManagement`を使用すると、Unityでのシーンの管理と制御を行うことができます。シーンの読み込み、切り替え、アンロードなど、さまざまな操作が可能です。以下に、`UnityEngine.SceneManagement`でできることとその具体的な使用例を説明します。

### `UnityEngine.SceneManagement`でできること

1. **シーンの読み込み**
2. **シーンのアンロード**
3. **シーンの再読み込み**
4. **シーンの切り替え**
5. **シーン情報の取得**
6. **アクティブシーンの設定**

### 主なクラスとメソッド

#### 1. シーンの読み込み
- **`SceneManager.LoadScene`**: 指定したシーンを読み込みます。

```csharp
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // シーンを読み込むメソッド
    public void LoadGameScene()
    {
        // シーン名またはインデックスを指定してシーンを読み込む
        SceneManager.LoadScene("GameScene");
        // SceneManager.LoadScene(1); // インデックスでも指定可能
    }
}
```

#### 2. シーンのアンロード
- **`SceneManager.UnloadSceneAsync`**: 指定したシーンを非同期でアンロードします。

```csharp
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // シーンをアンロードするメソッド
    public void UnloadGameScene()
    {
        // シーン名またはインデックスを指定してシーンをアンロード
        SceneManager.UnloadSceneAsync("GameScene");
    }
}
```

#### 3. シーンの再読み込み
- **`SceneManager.LoadScene`**: 現在のシーンを再読み込みします。

```csharp
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // シーンを再読み込みするメソッド
    public void ReloadCurrentScene()
    {
        // 現在のシーンを取得
        Scene currentScene = SceneManager.GetActiveScene();
        // 現在のシーンを再読み込み
        SceneManager.LoadScene(currentScene.name);
    }
}
```

#### 4. シーンの切り替え
- **`SceneManager.LoadScene`**: 別のシーンに切り替えます。

```csharp
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // 別のシーンに切り替えるメソッド
    public void SwitchToMainMenu()
    {
        // メインメニューシーンに切り替え
        SceneManager.LoadScene("MainMenu");
    }
}
```

#### 5. シーン情報の取得
- **`SceneManager.GetActiveScene`**: 現在アクティブなシーンを取得します。
- **`SceneManager.GetSceneByName`**: シーン名を指定してシーンを取得します。

```csharp
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneInfo : MonoBehaviour
{
    void Start()
    {
        // 現在のシーンを取得
        Scene currentScene = SceneManager.GetActiveScene();
        Debug.Log("現在のシーン名: " + currentScene.name);
        
        // シーン名を指定してシーンを取得
        Scene specificScene = SceneManager.GetSceneByName("GameScene");
        Debug.Log("GameSceneのインデックス: " + specificScene.buildIndex);
    }
}
```

#### 6. アクティブシーンの設定
- **`SceneManager.SetActiveScene`**: 指定したシーンをアクティブシーンとして設定します。

```csharp
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // アクティブシーンを設定するメソッド
    public void SetActiveGameScene()
    {
        // シーン名を指定してシーンを取得
        Scene gameScene = SceneManager.GetSceneByName("GameScene");
        // 取得したシーンをアクティブシーンとして設定
        SceneManager.SetActiveScene(gameScene);
    }
}
```

### 用語の解説

#### 1. シーン
- **説明**: シーンは、ゲームの特定の状態やステージを表します。例えば、メインメニュー、ゲームプレイ、ゲームオーバーなどがシーンとして作成されます。

#### 2. アクティブシーン
- **説明**: アクティブシーンは、現在表示されているシーンのことです。アクティブシーンを変更すると、表示されるシーンが変わります。

#### 3. 非同期
- **説明**: 非同期は、処理がバックグラウンドで行われることを意味します。非同期でシーンをアンロードすると、ゲームのパフォーマンスが向上します。

### スクリプトの流れの説明

1. **LoadSceneメソッド**:
   - シーンを読み込みます。シーン名やインデックスを指定して、新しいシーンに切り替えます。

2. **UnloadSceneAsyncメソッド**:
   - 指定したシーンを非同期でアンロードします。これにより、シーンがバックグラウンドでアンロードされ、ゲームのパフォーマンスが向上します。

3. **ReloadCurrentSceneメソッド**:
   - 現在のシーンを再読み込みします。これにより、シーンが最初から再生されます。

4. **SwitchToMainMenuメソッド**:
   - 別のシーンに切り替えます。例えば、ゲームプレイシーンからメインメニューシーンに戻る場合に使用します。

5. **シーン情報の取得**:
   - 現在のシーンや特定のシーンの情報を取得します。これにより、シーンの状態を確認できます。

6. **SetActiveSceneメソッド**:
   - 指定したシーンをアクティブシーンとして設定します。これにより、表示されるシーンが変更されます。

これらの機能を使用することで、ゲーム内のシーン管理が簡単になります。シーンの切り替えや再読み込み、情報の取得などを効率的に行うことができます。
 */

public class Guide_SceneManagement : MonoBehaviour
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
