using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 アニメーション再生中にプレイヤーや地面のオブジェクトのコライダーをアニメーションに合わせて変更する方法は、プロの現場でもよく用いられる技術です。これにはいくつかのアプローチがあり、具体的なケースやプロジェクトの要件に応じて選択されます。以下に、代表的な方法をいくつか紹介します。

### 方法1: アニメーションイベントを使用

#### 概要
アニメーションイベントを使用して、特定のフレームやタイミングでコライダーのプロパティを変更します。これは、アニメーションの特定の瞬間に合わせてコライダーのサイズや形状を調整するのに便利です。

#### 手順

1. **アニメーションイベントの追加**
   - Unityの`Animation`ウィンドウを開き、変更したいアニメーションクリップを選択します。
   - アニメーションの特定のフレームで右クリックし、「Add Animation Event」を選択します。
   - イベントのメソッド名を設定します（例: `UpdateCollider`）。

2. **スクリプトの作成**
   - アニメーションイベントに対応するスクリプトを作成し、コライダーを変更するメソッドを実装します。

```csharp
using UnityEngine;

public class PlayerColliderController : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private PolygonCollider2D polygonCollider;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        polygonCollider = GetComponent<PolygonCollider2D>();
    }

    // アニメーションイベントから呼び出されるメソッド
    public void UpdateCollider(string colliderType)
    {
        if (colliderType == "Box")
        {
            boxCollider.enabled = true;
            polygonCollider.enabled = false;
        }
        else if (colliderType == "Polygon")
        {
            boxCollider.enabled = false;
            polygonCollider.enabled = true;
        }
    }
}
```

3. **アニメーションイベントの設定**
   - アニメーションウィンドウで追加したイベントに対して、`UpdateCollider`メソッドを設定し、引数としてコライダーのタイプを渡します。

### 方法2: Mecanimのレイヤーとマスクを使用

#### 概要
Mecanimのアニメーターでレイヤーとアバターマスクを使用して、特定のボディパーツのアニメーションやコライダーの変更を制御します。

#### 手順

1. **アバターマスクの作成**
   - `Project`ウィンドウで右クリックし、「Create」->「Avatar Mask」を選択して新しいアバターマスクを作成します。
   - マスクしたいボディパーツを選択します。

2. **アニメーターの設定**
   - `Animator`ウィンドウで新しいレイヤーを作成し、アバターマスクを適用します。
   - レイヤーに特定のアニメーションステートを追加し、そのステートでコライダーを変更します。

### 方法3: コライダーの複数設定とスクリプト制御

#### 概要
複数のコライダーをプレイヤーオブジェクトに設定し、スクリプトで有効・無効を切り替えます。これにより、アニメーションに応じて適切なコライダーを使用できます。

#### 手順

1. **複数のコライダーを設定**
   - プレイヤーオブジェクトに複数のコライダー（例えば、`BoxCollider2D`や`PolygonCollider2D`）を設定します。

2. **スクリプトの作成**
   - アニメーションの進行に応じて、コライダーの有効・無効を切り替えるスクリプトを作成します。

```csharp
using UnityEngine;

public class DynamicColliderController : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private PolygonCollider2D polygonCollider;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        polygonCollider = GetComponent<PolygonCollider2D>();
    }

    void Update()
    {
        // アニメーションステートに基づいてコライダーを切り替える
        AnimatorStateInfo stateInfo = GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);

        if (stateInfo.IsName("Idle"))
        {
            boxCollider.enabled = true;
            polygonCollider.enabled = false;
        }
        else if (stateInfo.IsName("Run"))
        {
            boxCollider.enabled = false;
            polygonCollider.enabled = true;
        }
    }
}
```

### 方法4: スクリプタブルオブジェクトを使用

#### 概要
スクリプタブルオブジェクトを使用してコライダーの設定をデータとして管理し、アニメーションやゲームの進行に応じて動的に変更します。

#### 手順

1. **スクリプタブルオブジェクトの作成**
   - コライダーの設定を保持するスクリプタブルオブジェクトを作成します。

```csharp
using UnityEngine;

[CreateAssetMenu(fileName = "ColliderData", menuName = "ScriptableObjects/ColliderData", order = 1)]
public class ColliderData : ScriptableObject
{
    public Vector2 offset;
    public Vector2 size;
}
```

2. **スクリプトでの使用**
   - スクリプタブルオブジェクトを使ってコライダーの設定を変更するスクリプトを作成します。

```csharp
using UnityEngine;

public class ColliderDataController : MonoBehaviour
{
    public ColliderData idleColliderData;
    public ColliderData runColliderData;

    private BoxCollider2D boxCollider;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    public void UpdateCollider(string state)
    {
        if (state == "Idle")
        {
            boxCollider.offset = idleColliderData.offset;
            boxCollider.size = idleColliderData.size;
        }
        else if (state == "Run")
        {
            boxCollider.offset = runColliderData.offset;
            boxCollider.size = runColliderData.size;
        }
    }
}
```

### まとめ

これらの方法を使って、アニメーションの進行に応じてプレイヤーやオブジェクトのコライダーを動的に変更することができます。プロジェクトの要件や特定の状況に応じて、最適な方法を選択してください。

- **アニメーションイベント**: 特定のフレームでコライダーを変更したい場合に便利。
- **Mecanimのレイヤーとマスク**: 複雑なアニメーション制御に適している。
- **複数のコライダーとスクリプト制御**: 複数のコライダーを設定し、スクリプトで動的に切り替える。
- **スクリプタブルオブジェクト**: データとしてコライダー設定を管理し、柔軟に変更する。
 */
public class AnimetionCollider : MonoBehaviour
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
