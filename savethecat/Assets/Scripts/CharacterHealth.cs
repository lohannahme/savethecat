using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterHealth : MonoBehaviour
{
    private float Health = 10;// todo: pegar do script de stats do jogador
    [SerializeField]
    private Text healthText;

    public void TakeDamage(float Damage)
    {
        Health-=Damage;
        Debug.Log("Health "+Health);
        healthText.text = ""+Health;
        if(Health <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
