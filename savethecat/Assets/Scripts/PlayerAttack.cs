using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField]
    private PlayerStats stats;
    private Collider2D collider;
    private SpriteRenderer attackSprite;
    private float damage = 1;

    void Awake()
    {
        damage = stats.GetBaseDamage();
        collider = GetComponent<Collider2D>();
        attackSprite = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Enemy"))
        {
            var targetEnemy = other.GetComponent<CharacterHealth>(); 
            Attack(targetEnemy);
        }
    }

    void Attack(CharacterHealth targetEnemy)
    {
        if(targetEnemy == null) return;

        targetEnemy.TakeDamage(damage);
    }

    void OnEnable()
    {
        attackSprite.enabled = true;
        collider.enabled = true;
    }

    void OnDisable()
    {
        attackSprite.enabled = false;
        collider.enabled = false;
    }
}
