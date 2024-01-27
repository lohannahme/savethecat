using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    private float Hp;
    private float playerSpeed;
    private float baseDamage;
    private float baseCooldown;

    public float GetHealthPoints()
    {
        return this.Hp;
    }
    public void SetHealthPoints(float Hp)
    {
        this.Hp = Hp;
    }
    public float GetBaseDamage()
    {
        return this.baseDamage;
    }
    public void SetBaseDamage(float damage)
    {
        this.baseDamage = damage;
    }
      public float GetBaseCooldown()
    {
        return this.baseCooldown;
    }
    public void SetBaseCooldown(float cooldown)
    {
        this.baseCooldown = cooldown;
    }
    public float GetSpeed()
    {
        return this.playerSpeed;
    }
    public void SetSpeed(float speed)
    {
        this.playerSpeed = speed;
    }
}
