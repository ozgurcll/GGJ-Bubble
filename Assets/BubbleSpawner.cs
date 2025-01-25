using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    public GameObject spawnlananbaloncuklar;
    public float time;
    void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    // Update is called once per frame
    void Update()
    {

    }
    public IEnumerator SpawnObject(float time)
    {
        while (true)
        {
            yield return new WaitForSeconds(time);
            SpawnBubble();
        }
    }

    public void SpawnBubble()
    {
        Instantiate(spawnlananbaloncuklar, new Vector3(Random.Range(-2f, 4f), 12.4f, 0), Quaternion.identity);
    }
}
