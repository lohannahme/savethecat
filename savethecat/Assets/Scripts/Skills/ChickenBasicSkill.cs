using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChickenBasicSkill : MonoBehaviour, ISkills
{
    private float _time;

    [SerializeField] private float _cooldown = 3;
    [SerializeField] private float _damage;

    [SerializeField] private Movement _movement;
    [SerializeField] private GameObject[] _projectiles;
    [SerializeField] private Transform _spawnTransform;

    public void UpdateSkill()
    {
        SpawnSkill();
    }

    private void SpawnSkill()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time > _time)
            {
                if (_movement.isFacingRight)
                {
                    Instantiate(_projectiles[0], _spawnTransform.position, Quaternion.identity);
                }
                else
                {
                    Instantiate(_projectiles[1], _spawnTransform.position, Quaternion.identity);
                }

                _time = _cooldown + Time.time;
            }
        }
    }

}
