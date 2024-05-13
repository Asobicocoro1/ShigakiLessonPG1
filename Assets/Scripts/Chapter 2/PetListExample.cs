using System.Collections;
using System.Collections.Generic; // リストを使うために必要
using UnityEngine;

/*
 解説
リストの作成：List<string> pets = new List<string>(); で新しいリストを作ります。このリストは文字列を保存するためのものです。
追加：pets.Add("いぬ"); のように .Add メソッドを使ってリストに新しいアイテムを追加します。
表示：foreach ループを使ってリストの中身を一つずつ取り出し、表示します。
削除：pets.Remove("とり"); でリストから特定のアイテムを削除します。
このようにリストを使うと、データの管理がとても便利になります。
また、リストは中にいくつデータがあっても、簡単に扱うことができるので、たくさんのデータを保存しておくのに最適です。
プログラミングでリストを上手に使うことができれば、いろいろな情報を簡単に整理できるようになりますよ。
 */

public class PetListExample : MonoBehaviour
{
    void Start()
    {
        // 新しいリストを作る
        List<string> pets = new List<string>();

        // リストにペットの名前を追加する
        pets.Add("いぬ");
        pets.Add("ねこ");
        pets.Add("とり");

        // リストからペットの名前を一つずつ表示する
        foreach (string pet in pets)
        {
            Debug.Log(pet);
        }

        // リストから「とり」を削除する
        pets.Remove("とり");

        // 「とり」を削除した後のリストの内容を表示する
        foreach (string pet in pets)
        {
            Debug.Log(pet);
        }
    }
}
