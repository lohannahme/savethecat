using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MilkProjectile : MonoBehaviour
{
    public float speed;
    public float damage;
    private Rigidbody2D rb;
    public PlayerStats player;
    public Vector3 direction;
    public ParticleSystem particles;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        damage = player.GetBaseDamage();
        speed = player.GetSpeed();
        rb.AddForce(direction * speed);
    }
    void FixedUpdate()
    {
        rb.AddForce(direction * speed);
    }
   void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 7)
        {
            collision.GetComponent<CharacterHealth>().TakeDamage(damage);
            Instantiate(particles, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
