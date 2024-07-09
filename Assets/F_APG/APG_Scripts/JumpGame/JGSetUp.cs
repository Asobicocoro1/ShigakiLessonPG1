using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpGameSetup : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject flagPrefab;
    public GameObject platformPrefab;
    public GameObject backgroundPrefab;

    void Start()
    {
        // 背景を生成
        Instantiate(backgroundPrefab, new Vector3(0, 0, 10), Quaternion.identity);

        // プレイヤーを生成
        Instantiate(playerPrefab, new Vector3(-8, -3.5f, 0), Quaternion.identity);

        // ゴールフラッグを生成
        Instantiate(flagPrefab, new Vector3(8, -3.5f, 0), Quaternion.identity);

        // プラットフォームを生成
        Instantiate(platformPrefab, new Vector3(0, -4, 0), Quaternion.identity);
    }
}

