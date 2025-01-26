using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScene : MonoBehaviour
{
    [SerializeField] private Transform altPlayer;
    [SerializeField] private float moveSpeed = 5f;

    private bool isPlayerInside = false;

    private void Update()
    {
        if (isPlayerInside)
        {
            altPlayer.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPlayerInside = true;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPlayerInside = false;
        }
    }
}
