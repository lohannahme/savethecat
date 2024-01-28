using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkShooter : MonoBehaviour
{
    private MouseRotation mouse;
    private Vector3 direction;
    private bool Shot = false;
    public GameObject projectile;
    public float lastHitTime;
    public float cooldown = 0.2f;

    void Start()
    {
        mouse = GetComponentInParent<MouseRotation>();
    }
    void Update()
    {
        Shot = Input.GetMouseButtonDown(0);
        direction = mouse.shootDirection;
        var rotation = mouse.pRotation;
       if (Shot && Time.time - lastHitTime > cooldown)
       {
        GameObject codeProjectile = Instantiate(projectile,transform.position,rotation); 
        codeProjectile.GetComponent<MilkProjectile>().direction = direction;
        lastHitTime = Time.time;
       }
    }
   
}
