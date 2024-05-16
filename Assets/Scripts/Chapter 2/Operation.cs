using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 1. 変数とデータ型
変数は、データを保存するための箱のようなものです。
例えば、あなたの名前や、持っているお菓子の数などを記録するために使います。
データ型は、その箱がどんな種類のものを入れられるかを教えてくれます。
たとえば、「数」を入れる箱や、「文字」を入れる箱があります。

2. 文字列を扱う
文字列とは、文字が並んだものです。名前や、好きな食べ物の名前など、言葉をプログラム内で使いたいときにstring型の変数を使います。

3変数に保存されたデータを使って、足し算や引き算などの計算を行うことができます。3

intは整数を保存するためのデータ型です。
stringは文字や文章を保存するためのデータ型です。

これらの基本的な概念が理解できれば、プログラミングでいろいろなことができるようになります。
変数を使って情報を保存したり、その情報を使って計算をしたり、文字情報を扱ったりすることが、プログラミングで楽しく遊ぶ第一歩です！

一通りの計算パターン
加算（足し算）、減算（引き算）、乗算（掛け算）、除算（割り算）などの基本的な演算と、その他の演算子についても説明します。

インクリメントとデクリメント
インクリメント（++）は、変数の値を1増やす操作です。デクリメント（--）は、変数の値を1減らす操作です。
 */


public class Operation : MonoBehaviour
{
    private int age = 10;  // 「int」は整数を入れる箱、「age」は変数名、10は入れる数
    private string nameimg = "ハル";  // 「string」は文字を入れる箱、「name」は変数名、"ハル"は入れる文字
    // Start is called before the first frame update
    void Start()
    {
        

        //ここでは、favoriteFoodという変数に"アイスクリーム"という文字列を保存し、それを表示しています。
        string favoriteFood = "アイスクリーム";
        Debug.Log("私の好きな食べ物は " + favoriteFood + " です。");

        //applesとorangesにそれぞれ数が入っていて、totalFruitsではこれらを足し算しています。
        int apples = 5;
        int oranges = 3;
        int totalFruits = apples + oranges;
        Debug.Log("果物の合計は " + totalFruits + " 個です。");

        int sum = 5 + 3; // 5と3を足す
        Debug.Log("合計: " + sum); // 出力: 合計: 8

        int difference = 10 - 6; // 10から6を引く
        Debug.Log("差: " + difference); // 出力: 差: 4

        int product = 4 * 2; // 4に2を掛ける
        Debug.Log("積: " + product); // 出力: 積: 8

        int quotient = 20 / 5; // 20を5で割る
        Debug.Log("商: " + quotient); // 出力: 商: 4

        int remainder = 7 % 3; // 7を3で割った余り
        Debug.Log("余り: " + remainder); // 出力: 余り: 1

        int number = 10;
        number++; // numberに1を足す
        Debug.Log("インクリメント後: " + number); // 出力: インクリメント後: 11

        number--; // numberから1を引く
        Debug.Log("デクリメント後: " + number); // 出力: デクリメント後: 10

    }
    //これらの演算子を使って、プログラム内で数値を計算したり、データを操作したりすることができます。
    //これにより、プログラムがより動的で有用なものになります。
    //小学生でも、これらの基本的な演算が理解できれば、プログラミングで遊びながら学ぶことが楽しくなるでしょう！
    // Update is called once per frame
    

}
