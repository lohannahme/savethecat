using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealth : MonoBehaviour
{
    [SerializeField] private bool _isEnemy;
    [SerializeField] private GameObject _xpOrb;

    [SerializeField]
    private Text healthText;
    [SerializeField]
    private EnemyStats stats;
    public AudioSource som;
    public GameObject visual;
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
            if (_isEnemy)
            {
                Instantiate(_xpOrb, transform.position, Quaternion.identity);
            }

            som.Play();
            visual.SetActive(false);
            GetComponent<CapsuleCollider2D>().enabled = false;

            Destroy(gameObject,5);
        }
    }
}
