using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerFX fx => GetComponent<PlayerFX>();
    public float moveSpeed = 2f;
    public float acceleration = 2f;
    public float drag = 1f;

    public KeyCode upKey;
    public KeyCode downKey;
    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode attackKey;

    private Vector2 velocity;


    public Transform attackCheck;
    public float attackRange;

    public Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Movement();
        Attack();
    }

    private void Movement()
    {
        Vector2 inputDirection = Vector2.zero;

        if (Input.GetKey(upKey)) inputDirection += Vector2.up;
        if (Input.GetKey(downKey)) inputDirection += Vector2.down;
        if (Input.GetKey(leftKey)) inputDirection += Vector2.left;
        if (Input.GetKey(rightKey)) inputDirection += Vector2.right;


        if (inputDirection != Vector2.zero)
        {
            velocity += inputDirection.normalized * acceleration * Time.deltaTime;
        }
        else
        {

            velocity = Vector2.Lerp(velocity, Vector2.zero, drag * Time.deltaTime);
        }


        velocity = Vector2.ClampMagnitude(velocity, moveSpeed);


        transform.Translate(velocity * Time.deltaTime, Space.World);


        if (velocity.magnitude > 0.1f)
        {
            float angle = Mathf.Atan2(velocity.y, velocity.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle - 90);
        }
    }

    private void Attack()
    {
        if (Input.GetKeyDown(attackKey))
        {
            anim.SetBool("Attack", true);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(attackCheck.position, attackRange);
    }

}