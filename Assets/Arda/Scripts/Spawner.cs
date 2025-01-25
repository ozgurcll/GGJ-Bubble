using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public ArdaScript ardascript;
    public GameObject Obstacles;
    public float time;
    void Start()
    {
        StartCoroutine(SpawnObject(time));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator SpawnObject(float time )
    {
        while (true)
        {
            Instantiate(Obstacles, new Vector3(Random.Range(-2f, 4f), 12.4f, 0), Quaternion.identity);
            yield return new WaitForSeconds(time);

        }
    }
}
