using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveEggsSkill : MonoBehaviour, ISkills
{
    [SerializeField] private GameObject _eggs;

    [SerializeField] private float _eggsCooldown = 3;
    [SerializeField] private float _eggsDamage;

    private float _eggsTime;


    public void UpdateSkill()
    {
        SpawnEggs();
    }


    private void SpawnEggs()
    {
        if (Time.time > _eggsTime)
        {
            Instantiate(_eggs, transform.position, Quaternion.identity);
            _eggsTime = _eggsCooldown + Time.time;
        }
    }
}
