using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField]
    private float attackCooldown = .5f;
    
    private float lastAttackTime = 0;
    private float damage = 1;// todo: pegar do script de stats do jogador
    private CharacterHealth targetEnemy = null;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            targetEnemy = other.GetComponent<CharacterHealth>(); 
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            targetEnemy = null;
        }
    }

    void Attack()
    {
        if(targetEnemy == null) return;

        if(Time.time > lastAttackTime + attackCooldown)
        {
            targetEnemy.TakeDamage(damage);
            lastAttackTime = Time.time;
        }
    }

    void Update()
    {
        Attack();
    }
}
