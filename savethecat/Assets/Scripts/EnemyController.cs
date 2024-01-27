using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Rigidbody2D rb;
    public Transform player;
    public float EnemySpeed = 2f;
    public bool isFacingRight = true;
    public float minDistance = 1f;
    public float hitCooldown = 0.5f;
    private float lastHitTime ;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
          if (player.position.x > rb.position.x)
        {
            transform.localScale = new Vector2(1f,transform.localScale.y);
            isFacingRight = true;
        }
        else if (player.position.x < rb.position.x)
        {
            transform.localScale = new Vector2(-1f,transform.localScale.y);
            isFacingRight = false;
        }
    }
    void FixedUpdate()
    {
        if (Vector2.Distance(rb.position,player.position) > minDistance)
        {
            rb.MovePosition(Vector3.MoveTowards(rb.position,player.position,EnemySpeed * Time.fixedDeltaTime));
        }
    }
    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player") && (Time.time - lastHitTime) >  hitCooldown)
        {
                //deal damage
                //Debug.Log("Dealt Damage");
                //var player = col.gameObject.GetComponent<PlayerStats>();
                //player.DealDamage(damage)
                lastHitTime = Time.time;
        }
    }
}
