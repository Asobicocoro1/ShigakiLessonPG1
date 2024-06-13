using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 シーン移動させながらステージを遊ばせるか、1つのシーンで遊ばせるか、どちらが効率的かは、具体的なゲームの内容や設計によります。それぞれのアプローチには利点と欠点があるので、それらを理解することで最適な方法を選択できます。

### シーン移動を伴うアプローチ

#### 利点
1. **リソース管理**:
   - 各シーンで使用するリソースを個別に管理できるため、一度にメモリに読み込むデータ量を減らすことができます。
   - 大規模なゲームや複雑なステージにおいて、リソースのロードとアンロードが効率的に行えます。

2. **モジュール化**:
   - 各ステージを独立したシーンとして扱うことで、開発者が複数のステージを並行して作成・編集しやすくなります。
   - バグの原因を特定しやすく、デバッグが容易です。

3. **ステージ間の遷移**:
   - プレイヤーがステージをクリアするたびに、次のステージへシームレスに移行する演出が可能です。
   - 特定のステージのみをテストするのが簡単です。

#### 欠点
1. **ロード時間**:
   - 各シーンの読み込みに時間がかかる場合があります。特にステージ間の移動が頻繁なゲームでは、ロード時間がプレイヤーの体験を損なう可能性があります。

2. **状態の管理**:
   - プレイヤーの状態やゲーム進行状況をシーン間で保持するために、追加の管理が必要です。

### 1つのシーンで遊ばせるアプローチ（シーン内の動的ステージ）

#### 利点
1. **シームレスな体験**:
   - ステージ間の移行がシームレスに行われるため、プレイヤーの没入感が高まります。
   - ロード時間が発生しないので、スムーズなゲームプレイが可能です。

2. **統一された管理**:
   - プレイヤーの状態やゲーム進行状況を一元管理しやすくなります。
   - シーン内でステージを動的に変更するため、複雑なリソース管理が不要です。

#### 欠点
1. **メモリ使用量**:
   - すべてのステージのリソースを一度にメモリに保持する必要があるため、メモリ使用量が多くなります。
   - 大規模なゲームや複雑なステージの場合、メモリ不足やパフォーマンスの低下が発生する可能性があります。

2. **開発の複雑さ**:
   - ステージごとの状態や配置を動的に変更するためのスクリプトが複雑になる場合があります。
   - ゲーム全体の調整やデバッグが難しくなることがあります。

### おすすめの方法

1. **シーン移動を伴うアプローチ**:
   - 大規模なゲームや複雑なステージが多い場合に適しています。
   - リソース管理を効率的に行いたい場合や、ステージごとに異なる演出や設定が必要な場合に有効です。

2. **1つのシーンで遊ばせるアプローチ**:
   - シンプルなゲームやステージ間の移行が頻繁なゲームに適しています。
   - シームレスなゲームプレイ体験を提供したい場合に有効です。

### 実装例

#### シーン移動を伴うアプローチ
```csharp
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour
{
    public string[] stageScenes;
    private int currentStageIndex = 0;

    void Start()
    {
        LoadStage(currentStageIndex);
    }

    void LoadStage(int stageIndex)
    {
        SceneManager.LoadScene(stageScenes[stageIndex]);
    }

    public void LoadNextStage()
    {
        currentStageIndex++;
        if (currentStageIndex < stageScenes.Length)
        {
            LoadStage(currentStageIndex);
        }
        else
        {
            Debug.Log("全てのステージをクリアしました！");
        }
    }
}
```

#### 1つのシーンで遊ばせるアプローチ
```csharp
using UnityEngine;

public class StageManager : MonoBehaviour
{
    public GameObject[] stages;
    private int currentStageIndex = 0;
    private GameObject currentStage;

    void Start()
    {
        LoadStage(currentStageIndex);
    }

    void LoadStage(int stageIndex)
    {
        if (currentStage != null)
        {
            Destroy(currentStage);
        }

        currentStage = Instantiate(stages[stageIndex], Vector3.zero, Quaternion.identity);
    }

    public void LoadNextStage()
    {
        currentStageIndex++;
        if (currentStageIndex < stages.Length)
        {
            LoadStage(currentStageIndex);
        }
        else
        {
            Debug.Log("全てのステージをクリアしました！");
        }
    }
}
```

このように、それぞれのアプローチには利点と欠点があり、ゲームの内容や設計に応じて最適な方法を選択することが重要です。
 */

/*
 シーンを切り替える前のデータをロード後にも使用したい場合は、データを持ち越すための方法がいくつかあります。代表的な方法は以下の通りです。

### 方法1: シングルトンパターンを使用する

シングルトンパターンを使用して、データを持ち越すためのクラスを作成します。このクラスは、シーンを切り替えても破棄されずにデータを保持することができます。

```csharp
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // シングルトンインスタンス
    public static GameManager Instance { get; private set; }

    // 持ち越したいデータ
    public int playerScore;
    public Vector3 playerPosition;

    void Awake()
    {
        // シングルトンインスタンスを設定
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // シーンが切り替わっても破棄されないようにする
        }
        else
        {
            Destroy(gameObject); // 他のインスタンスが既に存在する場合は破棄する
        }
    }
}
```

### 方法2: PlayerPrefsを使用する

`PlayerPrefs` を使用して、簡単なデータを保存し、ロード後に再取得する方法です。これは、整数や浮動小数点数、文字列などの簡単なデータに適しています。

```csharp
// データの保存
PlayerPrefs.SetInt("PlayerScore", playerScore);
PlayerPrefs.SetFloat("PlayerPosX", playerPosition.x);
PlayerPrefs.SetFloat("PlayerPosY", playerPosition.y);
PlayerPrefs.SetFloat("PlayerPosZ", playerPosition.z);

// データの取得
playerScore = PlayerPrefs.GetInt("PlayerScore");
playerPosition = new Vector3(
    PlayerPrefs.GetFloat("PlayerPosX"),
    PlayerPrefs.GetFloat("PlayerPosY"),
    PlayerPrefs.GetFloat("PlayerPosZ")
);
```

### 方法3: スクリプト内でデータを保持する

データを持ち越すためのスクリプトを作成し、`DontDestroyOnLoad` を使用してシーン間でデータを保持します。

```csharp
using UnityEngine;

public class DataManager : MonoBehaviour
{
    // データを保持する変数
    public int playerScore;
    public Vector3 playerPosition;

    void Awake()
    {
        // オブジェクトを破棄しないように設定
        DontDestroyOnLoad(gameObject);
    }

    // データを保存するメソッド
    public void SaveData(int score, Vector3 position)
    {
        playerScore = score;
        playerPosition = position;
    }

    // データをロードするメソッド
    public void LoadData(out int score, out Vector3 position)
    {
        score = playerScore;
        position = playerPosition;
    }
}
```

### 方法4: ScriptableObjectを使用する

`ScriptableObject` を使用して、データを保持し、シーンを超えて使用する方法です。

```csharp
using UnityEngine;

[CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObjects/GameData", order = 1)]
public class GameData : ScriptableObject
{
    public int playerScore;
    public Vector3 playerPosition;
}

// 使用例
public class DataManager : MonoBehaviour
{
    public GameData gameData;

    void Start()
    {
        // データを保存
        gameData.playerScore = 100;
        gameData.playerPosition = new Vector3(1, 2, 3);

        // シーンの切り替え
        SceneManager.LoadScene("NextScene");
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // データをロード
        int score = gameData.playerScore;
        Vector3 position = gameData.playerPosition;
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
```

### まとめ

- **シングルトンパターン**: グローバルなアクセスを提供し、シーン間でデータを保持するための一般的な方法。
- **PlayerPrefs**: 小規模なデータを簡単に保存し、後で取得するための方法。
- **スクリプト内でデータを保持**: `DontDestroyOnLoad` を使用して、オブジェクトがシーン間で破棄されないようにする。
- **ScriptableObject**: データをオブジェクトとして保存し、シーン間で簡単にアクセス可能にする。

それぞれの方法には利点と欠点があり、特定の状況に応じて最適な方法を選択することが重要です。例えば、複雑なデータ構造や多くのデータを保持する必要がある場合は、シングルトンパターンやScriptableObjectが適しています。シンプルな整数や文字列データの場合は、PlayerPrefsが手軽で便利です。
 
 ### シーン間のデータ持ち越し方法の解説

シーンを切り替える前のデータをロード後に使用するための方法について、小学生にもわかるようにドキュメンテーションコメントと通常のコメントを追加し、詳しく説明します。

### 方法1: シングルトンパターンを使用する

シングルトンパターンを使用して、データを持ち越すためのクラスを作成します。このクラスは、シーンを切り替えても破棄されずにデータを保持することができます。

```csharp
using UnityEngine;

/// <summary>
/// ゲーム全体で使うデータを管理するクラス
/// </summary>
public class GameManager : MonoBehaviour
{
    // シングルトンインスタンス
    public static GameManager Instance { get; private set; }

    // プレイヤーのスコアを保存する変数
    public int playerScore;
    // プレイヤーの位置を保存する変数
    public Vector3 playerPosition;

    /// <summary>
    /// ゲーム開始時に呼ばれるメソッド
    /// </summary>
    void Awake()
    {
        // インスタンスが存在しない場合は、このオブジェクトをインスタンスとして設定
        if (Instance == null)
        {
            Instance = this;
            // シーンが切り替わってもオブジェクトを破棄しないようにする
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // 他のインスタンスが既に存在する場合はこのオブジェクトを破棄
            Destroy(gameObject);
        }
    }
}
```

### 方法2: PlayerPrefsを使用する

`PlayerPrefs` を使用して、簡単なデータを保存し、ロード後に再取得する方法です。これは、整数や浮動小数点数、文字列などの簡単なデータに適しています。

```csharp
using UnityEngine;

public class PlayerPrefsExample : MonoBehaviour
{
    // プレイヤーのスコアを保存するメソッド
    public void SavePlayerData(int score, Vector3 position)
    {
        // スコアを保存
        PlayerPrefs.SetInt("PlayerScore", score);
        // 位置を保存
        PlayerPrefs.SetFloat("PlayerPosX", position.x);
        PlayerPrefs.SetFloat("PlayerPosY", position.y);
        PlayerPrefs.SetFloat("PlayerPosZ", position.z);
    }

    // プレイヤーのスコアをロードするメソッド
    public void LoadPlayerData(out int score, out Vector3 position)
    {
        // スコアを取得
        score = PlayerPrefs.GetInt("PlayerScore");
        // 位置を取得
        position = new Vector3(
            PlayerPrefs.GetFloat("PlayerPosX"),
            PlayerPrefs.GetFloat("PlayerPosY"),
            PlayerPrefs.GetFloat("PlayerPosZ")
        );
    }
}
```

### 方法3: スクリプト内でデータを保持する

データを持ち越すためのスクリプトを作成し、`DontDestroyOnLoad` を使用してシーン間でデータを保持します。

```csharp
using UnityEngine;

/// <summary>
/// データを保持するクラス
/// </summary>
public class DataManager : MonoBehaviour
{
    // プレイヤーのスコアを保存する変数
    public int playerScore;
    // プレイヤーの位置を保存する変数
    public Vector3 playerPosition;

    /// <summary>
    /// ゲーム開始時に呼ばれるメソッド
    /// </summary>
    void Awake()
    {
        // オブジェクトを破棄しないように設定
        DontDestroyOnLoad(gameObject);
    }

    // データを保存するメソッド
    public void SaveData(int score, Vector3 position)
    {
        playerScore = score;
        playerPosition = position;
    }

    // データをロードするメソッド
    public void LoadData(out int score, out Vector3 position)
    {
        score = playerScore;
        position = playerPosition;
    }
}
```

### 方法4: ScriptableObjectを使用する

`ScriptableObject` を使用して、データを保持し、シーンを超えて使用する方法です。

```csharp
using UnityEngine;

/// <summary>
/// データを保存するためのスクリプタブルオブジェクト
/// </summary>
[CreateAssetMenu(fileName = "GameData", menuName = "ScriptableObjects/GameData", order = 1)]
public class GameData : ScriptableObject
{
    public int playerScore;
    public Vector3 playerPosition;
}

// 使用例
public class DataManager : MonoBehaviour
{
    public GameData gameData;

    void Start()
    {
        // データを保存
        gameData.playerScore = 100;
        gameData.playerPosition = new Vector3(1, 2, 3);

        // シーンの切り替え
        SceneManager.LoadScene("NextScene");
    }

    // シーンがロードされたときに呼ばれるメソッド
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // データをロード
        int score = gameData.playerScore;
        Vector3 position = gameData.playerPosition;
    }

    void OnEnable()
    {
        // シーンロードイベントにメソッドを登録
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable()
    {
        // シーンロードイベントからメソッドを解除
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
```

### まとめ

- **シングルトンパターン**: ゲーム全体で使うデータを管理し、シーン間でデータを持ち越すための一般的な方法。
- **PlayerPrefs**: 小規模なデータを簡単に保存し、後で取得するための方法。設定やハイスコアなどに適しています。
- **スクリプト内でデータを保持**: `DontDestroyOnLoad` を使用して、オブジェクトがシーン間で破棄されないようにする方法。
- **ScriptableObject**: データをオブジェクトとして保存し、シーン間で簡単にアクセス可能にする方法。

それぞれの方法には利点と欠点があり、特定の状況に応じて最適な方法を選択することが重要です。例えば、複雑なデータ構造や多くのデータを保持する必要がある場合は、シングルトンパターンやScriptableObjectが適しています。シンプルな整数や文字列データの場合は、PlayerPrefsが手軽で便利です。
 */
public class StageManager : MonoBehaviour
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
