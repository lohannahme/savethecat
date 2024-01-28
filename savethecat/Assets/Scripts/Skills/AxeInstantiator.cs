using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeInstantiator : MonoBehaviour
{
    private bool Shot = false;
    public GameObject projectile;
    public float lastHitTime;
    public float cooldown = 0.2f;
    private bool hasAxeSkill;

    void Update()
    {
        hasAxeSkill = GetComponent<PlayerSkills>()._axeSkill;
        Shot = Input.GetMouseButtonDown(0);
       if (Shot && Time.time - lastHitTime > cooldown && hasAxeSkill)
       {
        Instantiate(projectile,(Vector2)transform.position,Quaternion.identity); 
        lastHitTime = Time.time;
       }
    }
   
}
