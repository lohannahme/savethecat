using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackController : MonoBehaviour
{
    [SerializeField]
    private GameObject attackObj;

    [SerializeField]
    private float attackCooldown = .5f;

    [SerializeField]
    private float attackDuration = .25f;
    
    private float lastAttackTime = 0;

    private bool isAttacking = false;
    
    
    void Update()
    {
        if(Time.time > lastAttackTime + attackCooldown)
        {
            attackObj.SetActive(true);
            lastAttackTime = Time.time;
            isAttacking = true;
        }
        
        if(isAttacking && (Time.time > lastAttackTime + attackDuration))
        {
            attackObj.SetActive(false);
            isAttacking = false;
        }
    }
}
