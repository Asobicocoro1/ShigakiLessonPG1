using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*



学習の目的の明確化 (1分)
目的: UnityでのPrefabの使用方法と当たり判定の実装を学び、効率的にオブジェクトを管理し、ゲーム内での衝突検出を行う技術を習得する。
講義 5 (20分)
内容: Prefabの作成と使用方法、ジェネレータスクリプトの実装方法を説明する。
Prefabの基本概念と利点。
Prefabの作成と実際の使用例。
ジェネレータスクリプトの作成とアタッチ。
Prefabの作成方法
オブジェクトの作成
シーン内でゲームオブジェクトを作成します（例えば、Cubeや2Dスプライト）。
Prefabとして保存
作成したオブジェクトをプロジェクトウィンドウの「Assets」フォルダ内にドラッグします。これでオブジェクトがPrefabとして保存されます。
ジェネレータスクリプトの作成とアタッチ
以下のようなジェネレータスクリプトを作成し、空のオブジェクトにアタッチします：
csharp
コードをコピーする
using UnityEngine;

public class ObjectGenerator : MonoBehaviour
{
    public GameObject prefab; // 生成するPrefab
    public float spawnTime = 3f; // 生成間隔

    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnTime);
    }

    void SpawnObject()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }
}
 */
public class Lecture5 : MonoBehaviour
{
   
}
