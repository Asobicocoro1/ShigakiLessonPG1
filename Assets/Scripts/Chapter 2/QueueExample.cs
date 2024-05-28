using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 解説
キューの作成：new Queue<int>() で新しいキューを作ります。このキューは整数を保存できます。
エンキュー操作：numbers.Enqueue(1); のようにして、キューの末尾に新しい数字を追加します。
デキュー操作：numbers.Dequeue(); を使って、キューの先頭の数字を取り出します。
              この操作で先に追加された数字が取り出され、キューから削除されます。
キューの状態確認：numbers.Count でキュー内のアイテム数を確認し、numbers.Peek() で次に取り出されるアイテムが何かを見ることができます。

キューは、順番に処理されるべきタスクやデータがある場合に非常に役立ちます。この先入れ先出しの性質が、特定のシナリオで非常に便利な管理方法を提供します。
 */

public class QueueExample : MonoBehaviour
{
    void Start()
    {
        Queue<int> numbers = new Queue<int>(); // 新しいキューを作る

        // キューに数字をエンキューする
        numbers.Enqueue(1);
        numbers.Enqueue(2);
        numbers.Enqueue(3);
        numbers.Enqueue(3);

        // キューから数字をデキューする
        Debug.Log(numbers.Dequeue()); // 1が表示される
        Debug.Log(numbers.Dequeue()); // 2が表示される

        // キューに残っている数字を確認
        Debug.Log("キューには " + numbers.Count + " 個の数字が残っています。");
        Debug.Log("次に取り出される数字は " + numbers.Peek() + " です。"); // 3が表示される
    }
}

