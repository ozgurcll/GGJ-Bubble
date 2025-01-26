using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baloncuklariçin : MonoBehaviour
{
    public GameObject baloncuksol;
    public GameObject baloncuksag;
    public GameObject baloncuk;
    public float time;
    void Start()
    {
        Destroy(gameObject, 4);
        StartCoroutine(SpawnObject(time));
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
    // Update is called once per frame
    void Update()
    {
        
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
