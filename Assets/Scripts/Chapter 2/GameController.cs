using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 この例では、Greet() という関数を作りました。
これは「こんにちは！」と言うだけの簡単な挨拶をする関数です。
Start() の中で Greet(); を呼び出すことで、ゲームが始まると自動的に挨拶をします。
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

