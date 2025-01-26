using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaloncukSpawn : MonoBehaviour
{
    public float speed = 6;
    public GameObject baloncuksol;
    public GameObject baloncuksag;
    public GameObject baloncuk;
    public GameObject balonsuzengel;
    public GameObject balonluengel;
    public float time;
    int[] number = new int[5];    
    void Start()
    {
        Destroy(gameObject, 4);
        StartCoroutine(SpawnObject(time));
    }

    private void FixedUpdate()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;

    }
    public void BaloncukDogurma()
    {
        int side = Random.Range(0, 2);
        if (side == 0)
        {
            Instantiate(baloncuk, baloncuksol.transform.position, Quaternion.identity);
        }
        else if (side == 1)
        {
            Instantiate(baloncuk, baloncuksag.transform.position, Quaternion.identity);
        }
    }
    public void EngelDoguran()
    {
        int index = Random.RandomRange(0, 6);
        switch (index)
        {
            case 1:
                Instantiate(balonluengel, baloncuksol.transform.position, Quaternion.identity);
                break;
            case 2:
                Instantiate(balonluengel, baloncuksol.transform.position, Quaternion.identity);
                break;
            case 3:
                Instantiate(balonluengel, baloncuksol.transform.position, Quaternion.identity);
                break;
            case 4:
                Instantiate(balonluengel, baloncuksol.transform.position, Quaternion.identity);
                break;
            case 5:
                Instantiate(balonsuzengel, baloncuksol.transform.position, Quaternion.identity);
                break;
            default:
                break;
        }
    }
    public IEnumerator SpawnObject(float time)
    {
        while (true)
        {
            BaloncukDogurma();
            yield return new WaitForSeconds(time);

        }
    }
}
