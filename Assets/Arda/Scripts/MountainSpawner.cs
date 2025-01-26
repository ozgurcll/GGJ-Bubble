using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MountainSpawner : MonoBehaviour
{
    public float time;
    public GameObject mountainleft;
    public GameObject mountainright;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnMountain(time));
    }
    public void MountatinDogurma( )
    {
        
        
        Instantiate(mountainleft, new Vector3(-20, 15, 0), Quaternion.identity);
        Instantiate(mountainright, new Vector3(13, 15, 0), Quaternion.identity);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator SpawnMountain(float time)
    {
        while (true)
        {
        MountatinDogurma();
        yield return new WaitForSeconds(time);

        }
    }
}
