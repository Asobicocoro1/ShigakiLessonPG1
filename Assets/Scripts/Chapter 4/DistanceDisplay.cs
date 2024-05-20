using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


/*
 Distance メソッド
Distance の説明
目的: Distance メソッドは、2つのポイント（位置）の間の距離を計算するために使用します。
使用方法: Vector2 や Vector3 のようなベクトルの間の距離を計算するために使います。
例えば、車の位置とフラッグの位置の間の距離を計算するために使います。
 
 ToString の説明
目的: ToString メソッドは、数値やオブジェクトを文字列に変換するために使用します。
使用方法: 例えば、float や int のような数値型の変数を文字列に変換してUIに表示するために使います。

 */


public class DistanceDisplay : MonoBehaviour
{
    // 車の位置情報を保存する変数
    public Transform carTransform;
    // フラッグの位置情報を保存する変数
    public Transform flagTransform;
    // 距離を表示するテキスト
    public TextMeshProUGUI distanceText;

    void Update()
    {
        // 車とフラッグの間の距離を計算
        float distance = Vector2.Distance(carTransform.position, flagTransform.position);

        // 距離をテキストに表示
        distanceText.text = "距離: " + distance.ToString("F2") + "m";
    }
}

