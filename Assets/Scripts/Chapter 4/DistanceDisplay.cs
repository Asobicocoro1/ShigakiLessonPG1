using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceDisplay : MonoBehaviour
{
    public Text distanceText; // UIのテキストオブジェクトを設定するための変数
    private float distance; // 距離を保存する変数

    void Update()
    {
        // 距離を計算（ここでは例として時間を使って距離を増やします）
        distance += Time.deltaTime * 5; // 例: 毎秒5メートル増加

        // テキストを更新
        distanceText.text = "距離: " + distance.ToString("F2") + "m";
    }
}
