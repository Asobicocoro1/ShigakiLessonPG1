using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 続けて、UnityのColliderの使い方や設定方法について、さらに詳細に説明します。

### Colliderの詳細設定

#### Box Collider（ボックスコライダー）
- **Size（サイズ）**: コライダーの幅、高さ、奥行きを設定します。
- **Center（中心）**: コライダーの中心を設定します。

#### Sphere Collider（スフィアコライダー）
- **Radius（半径）**: コライダーの半径を設定します。
- **Center（中心）**: コライダーの中心を設定します。

#### Capsule Collider（カプセルコライダー）
- **Radius（半径）**: カプセルの円の部分の半径を設定します。
- **Height（高さ）**: カプセルの高さを設定します。
- **Direction（方向）**: カプセルの方向を設定します（X軸、Y軸、Z軸）。

#### Mesh Collider（メッシュコライダー）
- **Convex（凸形）**: メッシュを凸形状にするかどうかを設定します。動くオブジェクトには必ずチェックを入れます。
- **Cooking Options（調理オプション）**: メッシュの最適化設定です。基本的にデフォルトのままでOKです。

#### Terrain Collider（テレインコライダー）
- **Terrain Data（地形データ）**: 地形データを設定します。地形データはTerrainコンポーネントで生成されたデータです。

#### Wheel Collider（ホイールコライダー）
- **Radius（半径）**: ホイールの半径を設定します。
- **Suspension Distance（サスペンション距離）**: サスペンションの動く範囲を設定します。
- **Force App Point Distance（力の適用ポイント距離）**: ホイールに力が加わる位置を設定します。
- **Center（中心）**: ホイールの中心を設定します。
- **Suspension Spring（サスペンションスプリング）**: サスペンションのばね特性を設定します。

### 2D用のCollider詳細設定

#### Box Collider 2D（ボックスコライダー2D）
- **Size（サイズ）**: コライダーの幅と高さを設定します。
- **Offset（オフセット）**: コライダーの中心を設定します。

#### Circle Collider 2D（サークルコライダー2D）
- **Radius（半径）**: コライダーの半径を設定します。
- **Offset（オフセット）**: コライダーの中心を設定します。

#### Capsule Collider 2D（カプセルコライダー2D）
- **Size（サイズ）**: コライダーの幅と高さを設定します。
- **Direction（方向）**: カプセルの方向を設定します（水平か垂直）。

#### Polygon Collider 2D（ポリゴンコライダー2D）
- **Points（ポイント）**: コライダーの頂点を設定します。複雑な形状を作るために使います。

#### Edge Collider 2D（エッジコライダー2D）
- **Points（ポイント）**: コライダーの頂点を設定します。線状の形状を作るために使います。

### Is Trigger（トリガー）の設定

- **Is Trigger（トリガー）**: このチェックボックスをオンにすると、コライダーが物理的な衝突を無視し、他のオブジェクトがコライダー内に入ったことを検出します。これにより、物体がぶつかることなく、当たり判定を行うことができます。
  - **使い方の例**: プレイヤーがアイテムを拾うとき、敵が攻撃範囲に入ったときなど。

### Physics Material（物理マテリアル）の設定

- **Material（マテリアル）**: コライダーに物理的な特性を追加します。物体の滑りやすさや跳ね返りの設定を行います。

#### Physics Materialのプロパティ
- **Friction（摩擦）**: 物体が他の物体と接触したときの摩擦の度合いを設定します。値が高いほど摩擦が強く、滑りにくくなります。
- **Bounciness（反発）**: 物体が他の物体と衝突したときの跳ね返りの度合いを設定します。値が高いほど跳ね返ります。

### まとめ

- **Colliderの追加方法**:
  1. ゲームオブジェクトを選択します。
  2. インスペクターウィンドウで「Add Component（コンポーネントを追加）」をクリックします。
  3. 「Collider」や「Collider 2D」と検索し、追加したいコライダーを選びます。

- **基本的なColliderの種類と用途**:
  - **Box Collider**: 四角い物体に使用。壁や床、箱など。
  - **Sphere Collider**: 丸い物体に使用。ボールやリンゴなど。
  - **Capsule Collider**: 細長い物体に使用。人型キャラクターや木の幹など。
  - **Mesh Collider**: 複雑な形状に使用。建物や岩など。
  - **Terrain Collider**: 地形に使用。山や谷がある地面など。
  - **Wheel Collider**: 車のホイールに使用。車やトラックなど。

- **2D用のCollider**:
  - **Box Collider 2D**: 四角い2Dの物体に使用。床や壁など。
  - **Circle Collider 2D**: 丸い2Dの物体に使用。ボールやコインなど。
  - **Capsule Collider 2D**: 細長い2Dの物体に使用。キャラクターなど。
  - **Polygon Collider 2D**: 複雑な形の2Dの物体に使用。地形やキャラクターなど。
  - **Edge Collider 2D**: 線状の2Dの物体に使用。地面のラインなど。

これで、Unityで使うColliderのコンポーネントとその設定方法についての理解が深まりました。何か質問があれば、遠慮なく聞いてくださいね！
 */

public class Lecture_Colliders : MonoBehaviour
{
 
}
