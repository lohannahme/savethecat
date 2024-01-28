using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Rigidbody2D rb;
    public Transform player;
    public float EnemySpeed;
    EnemyStats enemyStats;
    public bool isFacingRight = true;
    public float minDistance = 1f;
    public float hitCooldown ;
    private float lastHitTime ;
    private float damage;
    private float Hp;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        enemyStats = GetComponent<EnemyStats>();

        EnemySpeed = enemyStats.GetSpeed();
        hitCooldown = enemyStats.GetBaseCooldown();
        damage = enemyStats.GetBaseDamage();
        Hp = enemyStats.GetHealthPoints();
    }

    void Update()
    {
          if (player.position.x > rb.position.x)
        {
            transform.localScale = new Vector2(-1f,transform.localScale.y);
            isFacingRight = true;
        }
        else if (player.position.x < rb.position.x)
        {
            transform.localScale = new Vector2(1f,transform.localScale.y);
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
                var player = col.gameObject.GetComponent<PlayerHealth>();
                player.TakeDamage(damage);
                lastHitTime = Time.time;
        }
    }
}
