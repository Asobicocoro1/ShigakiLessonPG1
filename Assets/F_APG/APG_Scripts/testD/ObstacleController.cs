using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnRate = 2f;
    private float nextSpawnTime;
    public float minSpawnRate = 1f;
    public float spawnRateDecrease = 0.1f;

    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            SpawnObstacle();
            nextSpawnTime = Time.time + spawnRate;
            if (spawnRate > minSpawnRate)
            {
                spawnRate -= spawnRateDecrease;
            }
        }
    }

    void SpawnObstacle()
    {
        Vector3 spawnPosition = new Vector3(transform.position.x, Random.Range(-4f, 4f), transform.position.z);
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}
