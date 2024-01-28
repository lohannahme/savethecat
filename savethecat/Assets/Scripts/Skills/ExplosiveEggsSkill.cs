using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosiveEggsSkill : MonoBehaviour, ISkills
{
    [SerializeField] private GameObject _eggs;
    private float _eggsTime = 3;

    public void UpdateSkill()
    {
        SpawnEggs();
    }


    private void SpawnEggs()
    {
        if (Time.time > _eggsTime)
        {
            Instantiate(_eggs, transform.position, Quaternion.identity);
            _eggsTime = 3 + Time.time;
        }
    }
}