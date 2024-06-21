using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public GameObject evolutionItemPrefab;
    public float spawnRate = 5f;
    private float nextSpawnTime;

    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            SpawnEvolutionItem();
            nextSpawnTime = Time.time + spawnRate;
        }
    }

    void SpawnEvolutionItem()
    {
        Vector3 spawnPosition = new Vector3(transform.position.x, Random.Range(-4f, 4f), transform.position.z);
        Instantiate(evolutionItemPrefab, spawnPosition, Quaternion.identity);
    }
}
