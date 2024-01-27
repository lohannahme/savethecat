using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHealth : MonoBehaviour
{
    private float Health = 10;// todo: pegar do script de stats do jogador

    public void TakeDamage(float Damage)
    {
        Health-=Damage;
        Debug.Log("Health "+Health);
    }
}
