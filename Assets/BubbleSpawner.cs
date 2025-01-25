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
            
        }
    }

    
}
