using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 ### 講義2: Physicsの基本概念

#### 学習の目的の明確化 (1分)
**説明**: 物理演算を使用してプレイヤを動かし、オブジェクトの衝突や重力の影響を実装します。これにより、ゲーム内でリアルな物理挙動を再現する方法を学びます。

#### 講義 (20分)
**内容**: Physicsの基本概念（6-3 Physicsについて学ぼう）

##### 6-3-1 Physicsとは
- **説明**: Physics（物理演算）は、Unityでリアルな物理現象を再現するための機能です。重力や衝突、摩擦などを簡単に実装できます。

##### 6-3-2 Physicsを使ってプレイヤを動かす
- **プレイヤにRigidbody 2Dを追加する方法**
  - プレイヤのオブジェクトを選択します。
  - Inspectorウィンドウで「Add Component」をクリックし、「Rigidbody 2D」を選択します。
  - これにより、プレイヤは重力の影響を受けるようになります。

##### 6-3-3 雲を足元に配置する
- **雲オブジェクトの作成と配置**
  - Hierarchyウィンドウで「Create」→「2D Object」→「Sprite」を選択します。
  - 新しいオブジェクトの名前を「Cloud」に変更し、雲のスプライトをアタッチします。
  - Sceneビューで雲オブジェクトをプレイヤの足元にドラッグして配置します。

##### 6-3-4 雲にもPhysicsを適用する
- **雲にCollider 2Dを追加する方法**
  - Cloudオブジェクトを選択し、Inspectorウィンドウで「Add Component」をクリックし、「Box Collider 2D」を選択します。
  - これにより、プレイヤが雲に触れると物理的な反応（跳ね返りなど）が発生します。

##### 6-3-5 雲が重力の影響を受けないように設定する
- **雲のRigidbody 2Dの設定**
  - Cloudオブジェクトに「Rigidbody 2D」を追加します。
  - Inspectorウィンドウで、Rigidbody 2Dの「Gravity Scale」を0に設定します。これにより、雲は重力の影響を受けません。

#### Unity上で個人操作 (10分)
- **内容**: プレイヤにRigidbody 2DとCollider 2Dをアタッチし、雲を配置する
  - プレイヤオブジェクトにRigidbody 2Dを追加し、雲オブジェクトを作成して配置します。
  - 雲にBox Collider 2Dを追加し、Rigidbody 2DのGravity Scaleを0に設定します。

#### 生徒同士で説明 (10分)
- **内容**: 学んだことを互いに説明し合い、理解を深める
  - 生徒同士で、Physicsの基本概念やプレイヤと雲の設定方法を説明し合いましょう。
  - 理解を深めるために、わからないことを質問したり、アドバイスをし合いましょう。

これで、Physicsの基本概念に関する講義は終了です。次に進む前に、休憩を取りましょう。
 */
public class Lecture6_1 : MonoBehaviour
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
