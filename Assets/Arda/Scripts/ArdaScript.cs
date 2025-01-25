using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArdaScript : MonoBehaviour
{
    public float XInput;
    public float movementspeed;
    public Rigidbody2D rb;
    public bool isDead = false;
    public GameManager managerGame;
    public GameObject deathscene;


    void Start()
    {
        
    }
    
    public void Die()
    {
        isDead = true;
        Time.timeScale = 0;
        deathscene.SetActive(true);
        
    }
    void Update()
    {
        XInput = Input.GetAxis("Horizontal");
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(XInput * movementspeed,rb.velocity.y);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore();  
        }
         
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            Die();
        }
    }
}
