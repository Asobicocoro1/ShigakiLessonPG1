using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 ### 講義5: ステージの作成（6-7 ステージを作ろう）

#### 学習の目的の明確化 (1分)
**説明**: プレイヤの動きに合わせてカメラを制御し、ステージを作成する方法を学びます。カメラコントローラの作成とPrefabの利用法を習得します。

#### 講義 (20分)
**内容**: ステージの作成（6-7 ステージを作ろう）

##### 6-7-1 雲のPrefabを作る
- **手順**:
  1. Hierarchyウィンドウで作成済みのCloudオブジェクトを選択します。
  2. Projectウィンドウで「Prefabs」フォルダを作成します。
  3. Cloudオブジェクトを「Prefabs」フォルダにドラッグ＆ドロップしてPrefabにします。

##### 6-7-2 雲のPrefabからインスタンスを作る
- **手順**:
  1. ProjectウィンドウでCloud Prefabを選択します。
  2. HierarchyウィンドウにCloud Prefabをドラッグ＆ドロップしてシーンにインスタンスを作成します。
  3. 必要に応じてCloudインスタンスを複製し、ステージに配置します。

##### 6-7-3 ゴールの旗を立てる
- **手順**:
  1. Hierarchyウィンドウで「Create」→「2D Object」→「Sprite」を選択します。
  2. 新しいオブジェクトの名前を「GoalFlag」に変更し、ゴールの旗のスプライトをアタッチします。
  3. Projectウィンドウで「Prefabs」フォルダにGoalFlagオブジェクトをドラッグ＆ドロップしてPrefabにします。

##### 6-7-4 背景画像の配置
- **手順**:
  1. Hierarchyウィンドウで「Create」→「2D Object」→「Sprite」を選択します。
  2. 新しいオブジェクトの名前を「Background」に変更し、背景画像のスプライトをアタッチします。
  3. Backgroundオブジェクトをシーンの後ろに配置し、カメラの視界全体を覆うように調整します。

### Unity上で個人操作 (10分)
- **内容**: 雲のPrefabを作成し、シーンにインスタンスを配置する
  - CloudオブジェクトをPrefabに変換し、シーンにインスタンスを配置します。
  - GoalFlagオブジェクトを作成し、Prefabにしてシーンに配置します。
  - 背景画像を設定し、シーンに配置します。

### 生徒同士で説明 (10分)
- **内容**: 学んだことを互いに説明し合い、理解を深める
  - 各自がどのようにPrefabを作成し、シーンにインスタンスを配置したかを説明し合います。
  - 背景画像の配置方法や調整について意見を交換します。

これで、ステージの作成に関する講義は終了です。次の講義では、プレイヤの移動に合わせてカメラを動かす方法について学びます。
 */
public class Lecture6_5 : MonoBehaviour
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
