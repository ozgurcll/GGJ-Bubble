using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float speed = 6;
    
    public GameObject baloncuk;
    public GameObject balonsuzengel;
    public GameObject balonluengel;
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
            EngelDoguran();
            yield return new WaitForSeconds(time);

        }
    }
    public void EngelDoguran()
    {
        int index = Random.Range(0, 10);
        switch (index)
        {
            case 1:
                Instantiate(balonluengel, new Vector2(Random.Range(-2,2),transform.position.y), Quaternion.identity);
                break;
            case 2:
                Instantiate(balonluengel, new Vector2(Random.Range(-2, 2), transform.position.y), Quaternion.identity);
                break;
            case 3:
                Instantiate(balonsuzengel, new Vector2(Random.Range(-2, 2), transform.position.y), Quaternion.identity);
                break;
            case 4:
                Instantiate(balonsuzengel, new Vector2(Random.Range(-2, 2), transform.position.y), Quaternion.identity);
                break;
            case 5:
                Instantiate(balonsuzengel, new Vector2(Random.Range(-2, 2), transform.position.y), Quaternion.identity);
                break;
            case 6:
                Instantiate(balonsuzengel, new Vector2(Random.Range(-2, 2), transform.position.y), Quaternion.identity);
                break;
            case 7:
                Instantiate(balonsuzengel, new Vector2(Random.Range(-2, 2), transform.position.y), Quaternion.identity);
                break;
            case 8:
                Instantiate(balonsuzengel, new Vector2(Random.Range(-2, 2), transform.position.y), Quaternion.identity);
                break;
            case 9:
                Instantiate(balonsuzengel, new Vector2(Random.Range(-2, 2), transform.position.y), Quaternion.identity);
                break;
            default:
                break;
        }
    }
}
