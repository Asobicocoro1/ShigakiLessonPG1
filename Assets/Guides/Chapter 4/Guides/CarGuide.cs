using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 ### スワイプのベクトル計算と車の移動のローカル変数について

このコードは、スワイプ入力に基づいて車を動かすためのものです。
各変数が何を意味し、どのように使われているかを丁寧に説明します。

```csharp
// スワイプのベクトル（方向と距離）を計算
Vector2 swipeVector = endMousePosition - startMousePosition;
// スワイプの距離を計算
float swipeDistance = swipeVector.magnitude;

// スワイプの方向を計算（ベクトルを正規化）
Vector2 direction = swipeVector.normalized;
// 車に力を加えて動かす（スワイプの距離に応じて）
rb.AddForce(direction * swipeDistance * 0.1f, ForceMode2D.Impulse);
```

#### 1. `swipeVector` の説明

```csharp
Vector2 swipeVector = endMousePosition - startMousePosition;
```
- **目的**: スワイプの方向と距離を計算するためのベクトルです。
- **型**: `Vector2`
- **説明**:
  - `Vector2` は、2次元のベクトルを表します。ここでは、X軸（横方向）とY軸（縦方向）の2つの値を持つベクトルです。
  - `endMousePosition` と `startMousePosition` は、スワイプの開始位置と終了位置を示すベクトルです。
  - `endMousePosition - startMousePosition` によって、スワイプの開始位置から終了位置までのベクトル（スワイプの方向と距離）が計算されます。

#### 2. `swipeDistance` の説明

```csharp
float swipeDistance = swipeVector.magnitude;
```
- **目的**: スワイプの全体の距離を計算するためです。
- **型**: `float`
- **説明**:
  - `swipeVector.magnitude` は、ベクトルの大きさ（長さ）を計算します。
  - これにより、スワイプの開始位置から終了位置までの直線距離が得られます。

#### 3. `direction` の説明

```csharp
Vector2 direction = swipeVector.normalized;
```
- **目的**: スワイプの方向を計算するためです。
- **型**: `Vector2`
- **説明**:
  - `swipeVector.normalized` は、ベクトルを正規化します。
  - 正規化とは、ベクトルの長さを1にすることです。この操作により、方向だけを表すベクトルが得られます。つまり、`direction` はスワイプの方向を示します。

#### 4. `rb.AddForce` の説明

```csharp
rb.AddForce(direction * swipeDistance * 0.1f, ForceMode2D.Impulse);
```
- **目的**: スワイプの方向と距離に基づいて車に力を加えて動かします。
- **関数**: `AddForce`
- **引数**:
  - `direction * swipeDistance * 0.1f`: 加える力の大きさと方向を示します。
    - `direction` はスワイプの方向です。
    - `swipeDistance` はスワイプの距離です。
    - `0.1f` は調整係数で、力の大きさを調整します。これにより、スワイプの距離が直接的に力の大きさに影響します。
  - `ForceMode2D.Impulse`: 力の加え方を指定します。`Impulse` は、瞬間的に力を加えるモードです。

### まとめ
このスクリプトは、ユーザーのスワイプ入力に基づいて車を動かすために、スワイプの開始位置と終了位置から方向と距離を計算し、その情報を使って車に力を加えています。
各変数はスワイプのベクトルや距離、方向を計算するために使われ、それに基づいて適切な力を車に加えて動かします。 
 */

public class CarGuide : MonoBehaviour
{
    
}
