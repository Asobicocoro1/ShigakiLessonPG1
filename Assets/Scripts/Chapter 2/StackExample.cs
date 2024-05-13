using System.Collections;
using System.Collections.Generic; // スタックを使うために必要
using UnityEngine;
/*
 * C#の標準ライブラリであるSystem.Collections.Generic名前空間にあるStack<T>クラスが提供するメソッド
 * UnityEngineが提供するものやほかの提供するメソッドがたくさんあります。
 * 
解説
スタックの作成：new Stack<string>() で新しいスタックを作ります。これで文字列を保存できるスタックができました。
プッシュ操作：books.Push("本1"); のようにして、スタックに新しい本を追加します。
              この操作でスタックの一番上に新しいアイテムが積み重なります。
ポップ操作：books.Pop(); を使って、スタックの一番上のアイテムを取り出します。
            この操作で最後に追加されたアイテムが取り出され、スタックから削除されます。
スタックの状態確認：books.Count でスタック内のアイテム数を確認し、books.Peek() で次に取り出されるアイテムが何かを見ることができます。

スタックは、後から入れたものを先に取り出すという特性を持っているため、逆順でデータを扱いたいときや、
最後に追加されたものにすぐにアクセスしたいときに非常に便利です。

*/

public class StackExample : MonoBehaviour
{
    void Start()
    {
        Stack<string> books = new Stack<string>(); // 新しいスタックを作る

        // スタックに本をプッシュする
        books.Push("本1");
        books.Push("本2");
        books.Push("本3");

        // スタックから本をポップする
        Debug.Log(books.Pop()); // "本3"が表示される
        Debug.Log(books.Pop()); // "本2"が表示される

        // スタックに残っている本を確認
        Debug.Log("スタックには " + books.Count + " 冊の本が残っています。");
        Debug.Log("次に取り出される本は " + books.Peek() + " です。"); // "本1"が表示される
    }
}

