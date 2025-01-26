using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public BubbleBar AssignedBar { get; set; }
    public bool isFulled = false;
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
            transform.localScale += new Vector3(0.07f, 0.07f, 0.07f);
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
        transform.localScale -= new Vector3(0.004f, 0.004f, 0.004f);
    }
}
