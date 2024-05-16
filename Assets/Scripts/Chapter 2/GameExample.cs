using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 簡単な説明
スタート位置：Vector3(0, 0, 0)は、ゲームの世界の中心点を意味します。
これはゲームの地面と同じ高さで、まっすぐ前を向いている状態です。
目的地：Vector3(10, 5, 0)は、スタート位置から右に10メートル、上に5メートル移動した場所を示しています。
Z値が0なので、前後には動きません。
Lerp関数：この関数は、「線形補間」と呼ばれ、二つの点の間をなめらかに移動するときに使います。
この例では、スタート位置と目的地のちょうど中間点にボールを移動させます。
このようにVector3を使うことで、ゲームの中で物の位置や動きを正確に制御できます。
ゲームを作るときに、どこに何を置くか、どう動かすかを考えるのにとても役立ちます。

プレイヤーの移動方法などはチャプター３でやります多分
 */

public class GameExample : MonoBehaviour
{
    void Start()
    {
        // Vector3を作る
        Vector3 startPosition = new Vector3(0, 0, 0);  // これはゲームの世界でのスタート位置を表す
        Vector3 endPosition = new Vector3(10, 5, 0);  // これはボールが飛んでいく目的地を表す

        // ボールをスタート位置から目的地へ動かす
        transform.position = Vector3.Lerp(startPosition, endPosition, 0.5f);  // Lerpは二つの場所の間を滑らかに移動する方法です
    }
}

