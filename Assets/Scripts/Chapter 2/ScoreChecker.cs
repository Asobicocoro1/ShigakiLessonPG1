using System.Collections;
using System.Collections.Generic;
using UnityEngine;//Unityエンジンが提供する機能を使うために必要です。
                  //UnityのクラスやメソッドをC#スクリプトで使えるようにするために、この行をファイルの最初に書きます。

/*
 詳細説明
public class ScoreChecker : MonoBehaviour：

この行は、ScoreCheckerという新しいクラスを作るところです。MonoBehaviourを継承しているので、
Unityのゲームオブジェクトにこのスクリプトをアタッチすることができ、Unityのイベントシステムを利用することができます。

public int score;：

ここでscoreという名前の公開された整数型の変数を定義しています。これにより、Unityのエディタから直接スコアの値を設定することができます。

void Start()内のif文：

Start関数内で条件文（if文）を使用して、スコアが100以上かどうかをチェックしています。100点以上なら「すごい！」と表示し、
それ以外なら「もっと頑張ろう！」と表示します。
これにより、プレイヤーにフィードバックを提供することができます。

ほかのパターン
1. 数値の比較:if (age < 13)
int age = 16;

if (age < 13) {
    Debug.Log("子供");
} else if (age < 20) {
    Debug.Log("ティーン");
} else {
    Debug.Log("大人");
}

2. 文字列の比較:

string password = "secret";

if (password == "secret") {
    Debug.Log("パスワードが正しいです。");
} else {
    Debug.Log("パスワードが間違っています。");
}

3. 複数の条件
複数の条件を&&（AND演算子）や||（OR演算子）で組み合わせて使います。
年齢が65歳以上であり、かつメンバーである場合に割引を適用

int age = 65;
bool isMember = true;

if (age >= 65 && isMember) {
    Debug.Log("割引が適用されます！");
}
4. ブール値のチェック
ブール値（真または偽）を直接チェックします。
bool isNight = true;

if (isNight) {
    Debug.Log("ライトをつけます。");
} else {
    Debug.Log("ライトを消します。");
}

5. ネストされた条件
条件の中に条件を入れることができ、より複雑なロジックを作成します。
年齢が18歳以上で身分証明書を持っている場合にのみアルコールの購入を許可しています。

int age = 20;
bool hasID = true;

if (age >= 18) {
    if (hasID) {
        Debug.Log("アルコールを購入できます。");
    } else {
        Debug.Log("身分証明が必要です。");
    }
} else {
    Debug.Log("購入できません。");
}


for分の未満の間,以下の,より大きい,以上の間　も使えますよ
自分で試してみてね

 */

public class ScoreChecker : MonoBehaviour
{
    //Unityのインスペクターウィンドウがスクリプト状に値を代入してif分を確認しましょう！
    // スコアを保存する変数
    public int score;

    void Start()
    {
        //↑ ゲーム開始時に一度だけ実行される
        if (score >= 100)
        {
            Debug.Log("すごい！");  // コンソールに「すごい！」と表示
        }
        else
        {
            Debug.Log("もっと頑張ろう！");  // コンソールに「もっと頑張ろう！」と表示
        }
    }
}

