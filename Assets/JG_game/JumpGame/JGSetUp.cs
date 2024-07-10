using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JGSetup : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject flagPrefab;
    public GameObject platformPrefab;
    public GameObject backgroundPrefab;

    private GameObject playerInstance;
    private GameObject flagInstance;

    void Start()
    {
        // 背景を生成
        Instantiate(backgroundPrefab, new Vector3(0, 0, 10), Quaternion.identity);
    }

    public void SetupStage1()
    {
        // プレイヤーを生成
        playerInstance = Instantiate(playerPrefab, new Vector3(-8, -3.5f, 0), Quaternion.identity);

        // ゴールフラッグを生成
        flagInstance = Instantiate(flagPrefab, new Vector3(8, -3.5f, 0), Quaternion.identity);

        // プラットフォームを生成
        Instantiate(platformPrefab, new Vector3(0, -4, 0), Quaternion.identity);
    }
}

