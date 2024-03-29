using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private float Hp = 1;
    private float maxHp = 1;
    private float playerSpeed = 2;
    private float xp = 1;
    private float maxXp = 1;
    private int Level = 1;
    private float baseDamage = 1;
    private float baseCooldown = 1;
    public string typeSpeed, typeDamage, typeHp;

    void Start()
    {



        if(PlayerPrefs.GetInt("Level" + typeSpeed)<=0){

                PlayerPrefs.SetInt("Level"+ typeSpeed,1);


        }   if(PlayerPrefs.GetInt("Level" + typeHp)<=0){

                PlayerPrefs.SetInt("Level"+ typeHp,1);


        }   if(PlayerPrefs.GetInt("Level" + typeDamage)<=0){

                PlayerPrefs.SetInt("Level"+ typeDamage,1);


        }
        Debug.Log(PlayerPrefs.GetInt("Level" + typeSpeed) + "TYPE SPEED");
        maxHp = PlayerPrefs.GetInt("Level" + typeHp)*3.2f;
        Hp = maxHp;
        playerSpeed = PlayerPrefs.GetInt("Level" + typeSpeed) * 1.08f;
        baseDamage = PlayerPrefs.GetInt("Level" + typeDamage) * 1.2f;
    }
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
