using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 講義の続きは「6-4 コライダの形を工夫してみよう」です。

### 講義 (20分)
**内容**: コライダの形状調整（6-4 コライダの形を工夫してみよう）

#### 6-4-1 オブジェクトにフィットする形状のコライダ
- **説明**: オブジェクトの形状に最も適したコライダを選ぶことで、よりリアルな物理挙動を実現できます。特に複雑な形状の場合、Polygon Collider 2Dを使うと便利です。

#### 6-4-2 プレイヤのコライダ形状を修正する
- **手順**:
  1. プレイヤオブジェクトを選択します。
  2. Inspectorウィンドウで現在のコライダ（例えば、Box Collider 2D）を確認します。
  3. 必要に応じて、Colliderのサイズや位置を調整します。
  4. もっと複雑な形状が必要な場合は、Polygon Collider 2Dを追加し、形状を手動で編集します。

#### 6-4-3 雲のコライダを調整する
- **手順**:
  1. Cloudオブジェクトを選択します。
  2. 既に追加されているPolygon Collider 2Dを「Edit Collider」で編集し、雲の形状に合わせて調整します。
  3. 雲の簡単な部分にはBox Collider 2Dを追加し、適切な位置とサイズに調整します。

### Unity上で個人操作 (10分)
- **内容**: プレイヤのCollider形状を調整する
  - プレイヤオブジェクトに追加されているColliderのサイズや形状を調整します。
  - 必要に応じて、新しいColliderを追加して形状を改善します。

### 生徒同士で説明 (10分)
- **内容**: 学んだことを互いに説明し合い、理解を深める
  - 各自がどのようにプレイヤや雲のCollider形状を調整したかを説明し合いましょう。
  - 調整のポイントや工夫した点について意見を交換しましょう。

これで、コライダの形状を工夫してリアルな物理挙動を実現する方法を学びました。次の講義では、プレイヤの動きをスクリプトで制御する方法を学びます。
 */

public class Lecture6_2 : MonoBehaviour
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
