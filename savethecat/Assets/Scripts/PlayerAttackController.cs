using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackController : MonoBehaviour
{
    [SerializeField]
    private PlayerAttack attackObj;
    private PlayerStats stats;

    // [SerializeField]
    private float attackCooldown = .5f;

    [SerializeField]
    private float attackDuration = .25f;
    
    private float lastAttackTime = 0;

    private bool isAttacking = false;
    
    void Awake()
    {
        stats = GetComponent<PlayerStats>();
        attackCooldown = stats.GetBaseCooldown();
    }


    void Update()
    {
        if(Time.time > lastAttackTime + attackCooldown)
        {
            attackObj.enabled = true;
            lastAttackTime = Time.time;
            isAttacking = true;
            attackObj.transform.localPosition = 
            new Vector3(
                -attackObj.transform.localPosition.x, 
                attackObj.transform.localPosition.y, 
                attackObj.transform.localPosition.z);
        }

        if(isAttacking && (Time.time > lastAttackTime + attackDuration))
        {
            attackObj.enabled = false;
            isAttacking = false;
        }
    }
}
