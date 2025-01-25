using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaloncukSpawn : MonoBehaviour
{
    public float speed = 6;
    public GameObject baloncuksol;
    public GameObject baloncuksag;
    public GameObject baloncuk;
    
    void Start()
    {
        Destroy(gameObject, 4);
        StartCoroutine(SpawnObject(5));
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
    public IEnumerator SpawnObject(float time)
    {
        while (true)
        {
            BaloncukDogurma();
            yield return new WaitForSeconds(10);

        }
    }
}
