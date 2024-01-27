using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealth : MonoBehaviour
{
    [SerializeField]
    private Text healthText;
    [SerializeField]
    private EnemyStats stats;

    void Start()
    {
        healthText.text = stats.GetHealthPoints().ToString();
    }

    public void TakeDamage(float Damage)
    {
        float currentHealth = stats.GetHealthPoints();
        currentHealth -= Damage;
        healthText.text = ""+currentHealth;
        stats.SetHealthPoints(currentHealth);

        if(currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
