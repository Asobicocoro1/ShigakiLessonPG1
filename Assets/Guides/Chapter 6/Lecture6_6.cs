using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 ### 講義6: プレイヤの移動に合わせてカメラを動かそう（6-8 プレイヤの移動に合わせてカメラを動かそう）

#### 学習の目的の明確化 (1分)
**説明**: プレイヤの動きに合わせてカメラを制御し、ステージを作成する方法を学びます。カメラコントローラの作成とPrefabの利用法を習得します。

#### 講義 (20分)
**内容**: カメラコントローラの作成（6-8 プレイヤの移動に合わせてカメラを動かそう）

##### 6-8-1 カメラをスクリプトで移動させる
- **手順**:
  1. Projectウィンドウで「Scripts」フォルダを開きます。
  2. 「Scripts」フォルダ内で右クリックし、「Create」→「C# Script」を選択し、スクリプト名を「CameraController」にします。
  3. CameraControllerスクリプトをダブルクリックして開き、以下のコードを入力します。

```csharp
using UnityEngine;

/// <summary>
/// プレイヤーの移動に合わせてカメラを制御するスクリプト
/// </summary>
public class CameraController : MonoBehaviour
{
    // プレイヤーのTransformへの参照
    public Transform player;

    // カメラとプレイヤーのオフセット
    private Vector3 offset;

    /// <summary>
    /// 初期設定を行うメソッド
    /// </summary>
    void Start()
    {
        // プレイヤーとカメラの初期オフセットを計算
        offset = transform.position - player.position;
    }

    /// <summary>
    /// フレームごとに呼び出されるメソッド
    /// </summary>
    void LateUpdate()
    {
        // プレイヤーの位置にオフセットを加算してカメラの位置を更新
        transform.position = player.position + offset;
    }
}
```

##### 6-8-2 カメラコントローラを作る
- **手順**:
  1. HierarchyウィンドウでMain Cameraを選択します。
  2. Inspectorウィンドウで「Add Component」をクリックし、「CameraController」スクリプトをアタッチします。

##### 6-8-3 カメラコントローラをアタッチする
- **手順**:
  1. CameraControllerスクリプトをアタッチしたMain CameraのInspectorウィンドウで、「Player」フィールドにプレイヤオブジェクトをドラッグ&ドロップして設定します。

### Unity上で個人操作 (10分)
- **内容**: カメラコントローラを作成し、プレイヤに合わせてカメラを移動させる
  - CameraControllerスクリプトを作成し、Main Cameraにアタッチします。
  - カメラの位置がプレイヤの動きに合わせて正しく移動するか確認します。

### 生徒同士で説明 (10分)
- **内容**: 学んだことを互いに説明し合い、理解を深める
  - 各自がどのようにCameraControllerスクリプトを作成し、カメラを設定したかを説明し合います。
  - カメラの動きの制御方法やスクリプトの役割について意見を交換します。

これで、プレイヤの移動に合わせてカメラを動かす方法を学びました。次の講義では、Physicsを使った当たり判定とシーン間の遷移方法を学びます。
 */
public class Lecture6_6 : MonoBehaviour
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
