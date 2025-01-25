using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public BubbleBar AssignedBar { get; set; } 
    [SerializeField] private bool isFulled = false;
    private float healTimer;
    private float healInterval = 0.2f;

    private void Start()
    {
        healTimer = healInterval;
    }
    private void Update()
    {
        healTimer -= Time.deltaTime;
        if (healTimer <= 0 && !isFulled)
        {
            healTimer = healInterval;
            transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
        }

        if (transform.localScale.x >= 2)
        {
            isFulled = true;
        }
    }

    public void MinesBubble()
    {
        transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
    }
}
