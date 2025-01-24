using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArdaScript : MonoBehaviour
{
    public float XInput;
    public float movementspeed;
    
    public Rigidbody2D rb;


    void Start()
    {
        
    }

    void Update()
    {
        XInput = Input.GetAxis("Horizontal");
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(XInput * movementspeed,rb.velocity.y);
    }
}
