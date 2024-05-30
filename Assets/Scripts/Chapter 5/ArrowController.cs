using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 - **日本語解説付きのスクリプトの説明**
  - `public float fallSpeed = 5f;`  
    - 矢の落下速度を設定します。例えば、5fとすると、速さが5のスピードで落ちます。

  - `void Update()`  
    - `Update`メソッドは、ゲームのフレームごとに呼び出されます。つまり、1秒間に何回も実行されます。

  - `transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);`  
    - `transform.Translate`は、オブジェクトを指定した方向に移動させるメソッドです。`Vector2.down`は下方向を示し、`fallSpeed`の速さで、`Time.deltaTime`（1フレームの時間）を掛けて移動します。

  - `if (transform.position.y < -10)`  
    - 矢のY軸の位置が-10より下になったら、つまり画面外に出たら、

  - `Destroy(gameObject);`  
    - `Destroy`メソッドを使って、矢のオブジェクトを消します。
 */
public class ArrowController : MonoBehaviour
{
    // 矢の落下速度を設定します
    public float fallSpeed = 5f;

    void Update()
    {
        // 矢を下に移動させます
        transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);

        // 矢が画面外に出たら破棄します
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
