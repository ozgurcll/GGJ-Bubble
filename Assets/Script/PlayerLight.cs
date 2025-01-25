using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerLight : MonoBehaviour
{
   [SerializeField] private Transform player; 

    private void Update()
    {
        // Vector3 direction = player.position - transform.position; 
        // float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; 
        // transform.rotation = Quaternion.Euler(0, 0, angle - 90);
    }
}
