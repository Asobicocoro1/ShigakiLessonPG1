using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*網羅できてない少し難しい内容一覧
 
 1. 論理演算
論理演算子は、真（true）や偽（false）といったブール値を操作する際に使用します。主な論理演算子には&&（AND）、||（OR）、!（NOT）があります。
bool isSunny = true;
bool isWeekend = false;

if (isSunny && isWeekend) {
    Debug.Log("公園へ行こう！");
} else {
    Debug.Log("家で過ごそう。");
}

if (!isWeekend) {
    Debug.Log("今日は学校がある日だ。");
}
このように論理演算を使って、複数の条件を組み合わせることができます。
 
 2. 条件演算子（三項演算子）
条件演算子は条件 ? 真の時の値 : 偽の時の値という形で使用され、簡単な条件分岐を1行で記述できます。
int score = 85;
string result = score >= 60 ? "合格" : "不合格";
Debug.Log(result);
このコードでは、スコアが60以上なら"合格"、そうでなければ"不合格"という結果をresultに格納します。


3. 配列とリストの高度な操作
配列やリストを使ったさらに複雑な操作もあります。例えば、配列やリストのソート、検索、またはフィルタリングなどです。
 List<int> numbers = new List<int> { 10, 5, 3, 9, 7 };
numbers.Sort(); // リストを昇順にソート

foreach (int number in numbers) {
    Debug.Log(number);
}
このコードでは、リスト内の数値を昇順に並べ替えています。

 4. イベントとデリゲートの基本
イベントとデリゲートを使って、プログラム内でカスタムの通知システムを設計する方法も学ぶことができます。
これにより、特定のアクションが発生したときに他のコードが反応するように設定することが可能です。
 public delegate void ActionEvent();
public event ActionEvent OnAction;

void DoSomething() {
    OnAction?.Invoke();
}
このコードでは、何かアクションをする際にイベントを発火させています。

これらのトピックを追加で学ぶことで、プログラミングの理解をより深め、さまざまな問題に対応できる力を身につけることができます。
プログラミングは非常に広い分野なので、基本から始めて徐々に新しい概念を取り入れていくことが重要です。
 
 

1. 例外処理
プログラム中でエラーが発生した場合に、それを安全に処理する方法を学ぶ。例外処理は、エラーがプログラムの実行を中断させないようにするために重要です。

csharp
コードをコピーする
try
{
    // ここに通常の処理を書く
    int division = 10 / 0; // ゼロで割り算をしてみる（エラー発生）
}
catch (DivideByZeroException ex)
{
    Debug.Log("ゼロで割ることはできません：" + ex.Message); // エラーメッセージを出力
}
2. ファイル入出力
データをファイルに保存したり、ファイルから読み込んだりする方法を学ぶ。これにより、ゲームのセーブデータ管理などが可能になります。

csharp
コードをコピーする
using System.IO;

string path = "path/to/your/file.txt";

// ファイルにテキストを書き込む
File.WriteAllText(path, "こんにちは、世界！");

// ファイルからテキストを読み取る
string readText = File.ReadAllText(path);
Debug.Log(readText);
3. 属性（Attributes）
コードにメタデータを追加する方法。例えば、Unityでよく使われる[SerializeField]や[Range]などがあります。これにより、エディタ内での表示や動作をカスタマイズできます。

csharp
コードをコピーする
public class Player : MonoBehaviour
{
    [SerializeField] private int health = 100; // エディターから調整可能にする
    [Range(1, 10)]
    public float speed = 5.0f; // スピードの範囲を1から10に制限する
}
4. デリゲートとイベントの応用
より複雑なデリゲートとイベントの使い方を学び、複数のイベントリスナーやアクションを管理する方法を理解する。

csharp
コードをコピーする
public delegate void HealthChanged(int newHealth);
public event HealthChanged onHealthChanged;

void TakeDamage(int damage)
{
    health -= damage;
    onHealthChanged?.Invoke(health);
}
5. ジェネリクスの使用
型をパラメータとして扱うことができるジェネリクスを使用する方法を学ぶ。これにより、より再利用可能で柔軟なコードが書けるようになります。

csharp
コードをコピーする
public class MyList<T>
{
    private List<T> list = new List<T>();

    public void Add(T item)
    {
        list.Add(item);
    }

    public T Get(int index)
    {
        return list[index];
    }
}
これらのトピックを学ぶことで、プログラミングの理解が深まり、より実践的で高度なプログラムを作成する能力が身につきます。
 
 
 
 
 
 
 
 
 
 */

public class Extra1 : MonoBehaviour
{
 
}
