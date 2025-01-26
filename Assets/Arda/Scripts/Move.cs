using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed = 4;
    public float accelaretion = 3f;
    //public GameManager gm;
    private float _defualtSpeed;
    public static bool isSpeedUp;
    void Start()
    {
        Destroy(gameObject,10);
    }
    private void OnEnable()
    {
       
        Debug.LogWarning("Enabled");
    }
    public void Hızlandır()
    {
        if (GameManager.instance.score % 1 == 0 && GameManager.instance.score != 0)
        {
            speed += accelaretion;
            Debug.Log("hızlandı");
        }

          
        
    }
    private void Update()
    {
        Hızlandır();
        
    }
    private void FixedUpdate()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;     
    }
    
}
