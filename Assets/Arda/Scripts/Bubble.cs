using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float speed;
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;

    }
}
