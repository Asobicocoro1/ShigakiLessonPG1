using System.Collections;
using System.Collections.Generic; // 辞書を使うために必要
using UnityEngine;

/*
 解説
!この辞書は文字列のキーと値を持ちます。!
辞書の作成：Dictionary<string, string> favoriteColors = new Dictionary<string, string>(); で新しい辞書を作ります。
追加：.Add メソッドを使って、友達の名前をキーとして、それに対応する好きな色を値として追加します。
取得：favoriteColors["ハル"] のように、キーを指定してその値を取得します。
削除：.Remove メソッドを使って特定のキー（ここでは「ユミ」）とその値を辞書から削除します。
内容の確認：foreach ループを使って辞書の中のすべてのキーと値を表示します。

entryの使い方
foreachループを使って辞書の中身を一つずつ見ていくときに、KeyValuePair<TKey, TValue>型の変数としてentryを使います。
これによって、各エントリのキーと値にアクセスすることができます。

辞書は情報を整理してすばやくアクセスするのにとても便利です。キーを知っていれば、そのキーに関連する情報をすぐに見つけることができるので、
プログラミングで情報を管理するときに役立ちますよ。
 */

public class FriendColors : MonoBehaviour
{
    void Start()
    {
        // 新しい辞書を作る
        Dictionary<string, string> favoriteColors = new Dictionary<string, string>();

        // 辞書に友達の名前と好きな色を追加する
        favoriteColors.Add("ハル", "青");
        favoriteColors.Add("ユミ", "ピンク");
        favoriteColors.Add("トモ", "緑");

        // ハルの好きな色を表示する
        Debug.Log("ハルの好きな色は " + favoriteColors["ハル"] + " です。");

        // ユミの好きな色を辞書から削除する
        favoriteColors.Remove("ユミ");

        // 辞書の内容を確認する
        foreach (KeyValuePair<string, string> entry in favoriteColors)
        {
            Debug.Log(entry.Key + "の好きな色は " + entry.Value + " です。");
        }
    }
}
