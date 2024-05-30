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

実際にオブジェクトを作り出す部分です。Instantiateメソッドを使って、指定されたPrefabを生成します。生成される位置はX軸が-10から10の間でランダムに、Y軸は常に9です。
--------------------------------------------------------------------------------------------------------------------
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

実際にオブジェクトを作り出す部分です。Instantiateメソッドを使って、指定されたPrefabを生成します。生成される位置はX軸が-10から10の間でランダムに、Y軸は常に9です。
float randomX = Random.Range(-10f, 10f);

X軸の位置を-10から10の間でランダムに設定します。
Vector3 spawnPosition = new Vector3(randomX, 9f, 0f);

生成されるオブジェクトの位置を設定します。この例では、X軸はランダム、Y軸は9に設定されています。
Instantiate(prefab, spawnPosition, Quaternion.identity);

指定された位置と回転でPrefabを生成します。Quaternion.identityは回転なしを意味します。
これで、Prefabの生成位置をX軸が±10、Y軸が9にするスクリプトが完成しました。分からないところがあったら、気軽に聞いてくださいね！
 
 
 
 */
public class ObjectGenerator_2 : MonoBehaviour
{
    public GameObject prefab; // 生成するPrefab
    public float spawnTime = 3f; // 生成間隔

    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnTime);
    }

    void SpawnObject()
    {
        // X軸の位置を-10から10の間でランダムに設定し、Y軸の位置を9に設定します
        float randomX = Random.Range(-10f, 10f);
        Vector3 spawnPosition = new Vector3(randomX, 9f, 0f);
        Instantiate(prefab, spawnPosition, Quaternion.identity);
    }
}
