using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    [SerializeField] GameObject[] bubblePrefabs;
    [SerializeField] Vector2 spawnAreaMin;
    [SerializeField] Vector2 spawnAreaMax;
    [SerializeField] float minSpawnInterval = 0.5f;
    [SerializeField] float maxSpawnInterval = 3.0f;

    void Start()
    {
        InvokeRepeating("SpawnBubble", Random.Range(minSpawnInterval, maxSpawnInterval), Random.Range(minSpawnInterval, maxSpawnInterval));
    }

    void SpawnBubble()
    {
        Vector2 spawnPosition = new Vector2(Random.Range(spawnAreaMin.x, spawnAreaMax.x), Random.Range(spawnAreaMin.y, spawnAreaMax.y));

        GameObject bubblePrefab = bubblePrefabs[Random.Range(0, bubblePrefabs.Length)];

        Instantiate(bubblePrefab, spawnPosition, Quaternion.identity);
    }
}
