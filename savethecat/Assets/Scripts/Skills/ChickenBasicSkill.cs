using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChickenBasicSkill : MonoBehaviour, ISkills
{
    private float _time;
    [SerializeField] private Movement _movement;
    [SerializeField] private GameObject[] _projectiles;

    public void UpdateSkill()
    {
        throw new System.NotImplementedException();
    }

    private void SpawnSkill()
    {
        if (Time.time > _time)
        {
            if (_movement.isFacingRight)
            {
               // Instantiate(_eggs, transform.position, Quaternion.identity);
            }

            _time = 3 + Time.time;
        }
    }
}
