using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 この例では、Greet() という関数を作りました。
これは「こんにちは！」と言うだけの簡単な挨拶をする関数です。
Start() の中で Greet(); を呼び出すことで、ゲームが始まると自動的に挨拶をします。

引数も返り値もないメソッド
引数も返り値もないメソッドは、ただ何かの作業をするだけで、外から何か情報を受け取らず（引数なし）、作業の結果を外に出さない（返り値なし）メソッドです。
 */

public class GameController : MonoBehaviour
{
    void Start()
    {
        // 関数を使って「こんにちは！」と挨拶する
        Greet();
    }

    // Greet関数: 挨拶をする
    void Greet()
    {
        Debug.Log("こんにちは！");
    }
}

