using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 説明
デリゲートとイベントの宣言：これは、イベントがどんなときに使われるかのルールを作る部分です。
イベントの発火：これは、風船が割れたという「ニュース」を他のプログラムの部分に伝えるために、イベントを起こす部分です。
イベントにメソッドを登録：これは、イベントが起きたときに何をするかをプログラムに教える部分です。
                          ここでは「Announce」というメソッドがイベントに反応します。
イベントが発生したときに実行されるメソッド：風船が割れたときに、「風船が割れました！皆、驚かないでね！」と表示するメソッドです。
このようにイベントを使うことで、プログラムの一部が他の部分に「何か特別なことが起こったよ」と教えることができます。
それを聞いた他の部分は、決められた反応をします。これがプログラミングでのイベントの基本的な使い方です。
 */

public class Party : MonoBehaviour
{
    // デリゲートとイベントの宣言
    public delegate void BalloonPoppedAction();
    public event BalloonPoppedAction OnBalloonPopped;

    void Start()
    {
        // イベントを発火させる（風船が割れたことを知らせる）
        if (OnBalloonPopped != null)
        {
            OnBalloonPopped();
        }
    }

    void OnEnable()
    {
        // イベントにメソッドを登録
        OnBalloonPopped += Announce;
    }

    void OnDisable()
    {
        // イベントからメソッドを削除
        OnBalloonPopped -= Announce;
    }

    // イベントが発生したときに実行されるメソッド
    void Announce()
    {
        Debug.Log("風船が割れました！皆、驚かないでね！");
    }
}
