using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBubble : MonoBehaviour
{
    [SerializeField] private GameObject bubble;
    [SerializeField] private GameObject eButton;
    [SerializeField] private GameObject timeBar;
    [SerializeField] private Transform bubbleSpawn;
    private bool isActive = false;
    private bool isBubbleActive = false;

    [SerializeField] private KeyCode activeKey;

    [SerializeField] private BubbleBar bubbleBar;

    private void Start()
    {
        eButton.SetActive(false);
        timeBar.SetActive(false);
    }

    private void Update()
    {
        if (isActive && Input.GetKeyDown(activeKey) && !isBubbleActive)
        {
            isBubbleActive = true;
            isActive = false;

            GameObject newBubble = Instantiate(bubble, bubbleSpawn.position, Quaternion.identity);

            Bubble bubbleComponent = newBubble.GetComponent<Bubble>();
            bubbleComponent.AssignedBar = bubbleBar;

            bubbleBar.GetBubble(bubbleComponent);

            eButton.SetActive(false);
            timeBar.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Player>() && !isBubbleActive)
        {
            isActive = true;
            eButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<Player>() && !isBubbleActive)
        {
            isActive = false;
            eButton.SetActive(false);
        }
    }
}
