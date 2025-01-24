using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBubble : MonoBehaviour
{
    [SerializeField] private GameObject bubble;
    [SerializeField] private GameObject eButton;
    [SerializeField] private Transform bubbleSpawn;
    [SerializeField] private bool isActive = false;

    private void Start()
    {
        eButton.SetActive(false);
    }

    private void Update()
    {
        if (isActive && Input.GetKeyDown(KeyCode.E))
        {
            isActive = false;
            GameObject newBubble = Instantiate(bubble, bubbleSpawn.position, Quaternion.identity);
            eButton.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Player>())
        {
            Debug.Log("Player is near the bubble");
            isActive = true;
            eButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<Player>())
        {
            Debug.Log("Player is far from the bubble");
            isActive = false;
            eButton.SetActive(false);
        }
    }
}
