using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private float Hp;
    private float maxHp;
    private float playerSpeed;
    private float xp;
    private float maxXp;
    private int Level;
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
    public float GetXp()
    {
        return this.xp;
    }
    public void SetXp(float xp)
    {
    this.xp = xp;    
    }
    public float GetMaxXp()
    {
        return this.maxXp;
    }
    public void SetMaxXp(float xp)
    {
        this.maxXp = xp;
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
    public float GetLevel()
    {
        return this.Level;
    }   
    public void SetLevel(int level)
    {
        this.Level = level;
    }
    public float GetSpeed()
    {
        return this.playerSpeed;
    }
    public void SetSpeed(float speed)
    {
        this.playerSpeed = speed;
    }
    public float GetMaxHp()
    {
        return this.maxHp;
    }
    public void SetMaxHp(float hp)
    {
        this.maxHp = hp;
    }
}
