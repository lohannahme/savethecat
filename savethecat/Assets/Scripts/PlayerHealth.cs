using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public UnityEvent OnDeath = new UnityEvent();
    private PlayerStats stats;
    private bool isDead = false;

    void Awake()
    {
        stats = GetComponent<PlayerStats>();
    }

    public void TakeDamage(float Damage)
    {
        if(isDead) return;

        float currentHealth = stats.GetHealthPoints();

        currentHealth -= Damage;
        stats.SetHealthPoints(currentHealth);

        if(currentHealth <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        isDead = true;
        GetComponent<Movement>().enabled = false;
        OnDeath.Invoke();
    }
}
