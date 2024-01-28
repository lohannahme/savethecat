using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class PlayerAttackController : MonoBehaviour
{
    [SerializeField]
    private PlayerAttack attackObj;
    private PlayerStats stats;

    private float attackCooldown = .25f;

    [SerializeField]
    private float attackDuration = .25f;
    
    private float lastAttackTime = 0;

    private bool isAttacking = false;
    
    void Awake()
    {
        stats = GetComponent<PlayerStats>();
        attackCooldown = stats.GetBaseCooldown();
    }

    void Start()
    {
        attackObj.enabled = false;
        isAttacking = false;
        attackCooldown = attackDuration;
    }

    void Update()
    {
        if(attackObj == null) return;

        if((Input.GetMouseButtonDown(0)) && Time.time > lastAttackTime + attackCooldown)
        {
            attackObj.enabled = true;
            lastAttackTime = Time.time;
            isAttacking = true;
        }

        if(isAttacking && (Time.time > lastAttackTime + attackDuration))
        {
            attackObj.enabled = false;
            isAttacking = false;
        }
    }
}
