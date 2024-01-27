using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Rigidbody2D rb;
    public Transform player;
    public float EnemySpeed = 2f;
    public bool isFacingRight = true;
    public float minDistance = 1f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
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
}
