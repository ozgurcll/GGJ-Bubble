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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            bubbleSpawner.SpawnBubble();
            Destroy(gameObject, 0.2f);
        }
    }
}
