using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private float spawnInterval = 5f;

    private float spawnTimer;
    private bool areBubblesFull = false; // Baloncukların doluluğunu kontrol eden değişken

    private void Update()
    {
        // Eğer baloncuklar %100 ise düşman spawn işlemi yapılmasın
        if (areBubblesFull)
            return;

        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0 && IsBubbleAvailable())
        {
            SpawnEnemy();
            spawnTimer = spawnInterval;
        }
    }

    private bool IsBubbleAvailable()
    {
        return FindObjectsOfType<Bubble>().Length > 0;
    }

    private void SpawnEnemy()
    {
        Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
    }

    // Baloncukların doluluk durumu değiştiğinde bu fonksiyon çağrılır
    public void SetBubblesFull(bool isFull)
    {
        areBubblesFull = isFull;
    }
}
