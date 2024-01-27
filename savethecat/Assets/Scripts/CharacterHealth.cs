using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealth : MonoBehaviour
{
    private float Health = 10;
    [SerializeField]
    private Text healthText;
    [SerializeField]
    private EnemyStats stats;

    void Start()
    {
        healthText.text = ""+stats.GetHealthPoints();
    }

    public void TakeDamage(float Damage)
    {
        float currentHealth = stats.GetHealthPoints();
        currentHealth -= Damage;
        healthText.text = ""+currentHealth;
        stats.SetHealthPoints(Health);

        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
