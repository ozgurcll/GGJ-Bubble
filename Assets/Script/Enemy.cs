using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float stopDistance = 1f;
    private Transform targetBubble;

    private void Start()
    {
        FindNearestBubble();
    }

    private void Update()
    {
        if (targetBubble != null)
        {
            MoveTowardsBubble();
        }
    }

    private void FindNearestBubble()
    {
        Bubble[] bubbles = FindObjectsOfType<Bubble>();
        float shortestDistance = Mathf.Infinity;
        Transform nearestBubble = null;

        foreach (Bubble bubble in bubbles)
        {
            float distance = Vector3.Distance(transform.position, bubble.transform.position);

            if (distance < shortestDistance)
            {
                shortestDistance = distance;
                nearestBubble = bubble.transform;
            }
        }

        targetBubble = nearestBubble;
    }

    private void MoveTowardsBubble()
    {
        float distanceToBubble = Vector3.Distance(transform.position, targetBubble.position);

        if (distanceToBubble > stopDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetBubble.position, speed * Time.deltaTime);

            Vector3 direction = (targetBubble.position - transform.position).normalized;
            float angleY = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

            transform.rotation = Quaternion.Euler(0, angleY, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Bubble>() != null)
        {
            other.GetComponent<Bubble>().MinesBubble();
            Debug.Log("SDASFS");
        }
    }

    private void OnDrawGizmos()
    {
        if (targetBubble != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, targetBubble.position);
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
