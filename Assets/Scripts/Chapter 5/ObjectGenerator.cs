using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
  日本語解説
public GameObject prefab;

これは、どのオブジェクトを作り出すかを指定します。例えば、敵キャラクターやアイテムなどのテンプレート（Prefab）です。
public float spawnTime = 3f;

これは、オブジェクトを作り出す間隔を秒単位で設定します。この例では、3秒ごとにオブジェクトが生成されます。
void Start()

ゲームが始まったときに一度だけ実行される部分です。
InvokeRepeating("SpawnObject", spawnTime, spawnTime);

指定したメソッド（この場合は「SpawnObject」）を繰り返し実行します。この例では、3秒ごとに「SpawnObject」を実行します。
void SpawnObject()

実際にオブジェクトを作り出す部分です。Instantiateメソッドを使って、指定されたPrefabを生成します。
 */
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
