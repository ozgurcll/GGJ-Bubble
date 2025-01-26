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
    public GameObject Bubble;
    public bool isbubbled;
    public GameObject player;
    public float time = 3f;
    public AudioClip pickupsound;
    private AudioSource audiosource;



    void Start()
    {
        isbubbled = false;
        audiosource = GetComponent<AudioSource>();
        Time.timeScale = 2;
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
        if (isbubbled)
        {
            player.GetComponent<CapsuleCollider2D>().isTrigger = true;   
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore();  
        }
        else if(collision.gameObject.tag == "Baloncuk")
        {
            Destroy(collision.gameObject);
            GameObject bubble = Instantiate(Bubble,transform.position,Quaternion.identity);
            bubble.transform.SetParent(transform);
            isbubbled = true;
            StartCoroutine(Baloncukgit(time,bubble));
            bubble.SetActive(true);
            audiosource.PlayOneShot(pickupsound);
            audiosource.loop = true;

        }
         
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "DeathArea")
        {
            Die();
        }
    }
   public IEnumerator Baloncukgit(float time, GameObject bubble )
    {
        yield return new WaitForSeconds(time);
        isbubbled = false;
        player.GetComponent<CapsuleCollider2D>().isTrigger = false;
        bubble.SetActive(false);
    }
}
