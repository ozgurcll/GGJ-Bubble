using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public BubbleSpawner bubbleSpawner;
    public float speed;
    void Start()
    {
        Destroy(gameObject,4);
    }

    private void FixedUpdate()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
       
    }
    
}
