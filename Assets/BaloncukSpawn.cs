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
        
    }

    private void FixedUpdate()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;

    }
    
    
   
}
