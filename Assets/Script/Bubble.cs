using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public BubbleBar AssignedBar { get; set; }
    public bool isFulled = false;
    private float healTimer;
    private float healInterval = 0.1f;



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
            transform.localScale += new Vector3(0.008f, 0.008f, 0.008f);
        }

        if (transform.localScale.x >= 2)
        {
            isFulled = true;
        }
        else
        {
            isFulled = false;
        }
    }

    public void MinesBubble()
    {
        transform.localScale -= new Vector3(0.007f, 0.007f, 0.007f);
    }
}
