using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChickenBasicSkill : MonoBehaviour, ISkills
{
    private float _time;
    private float _cooldown = 3;
    private float _damage = 10;
    private ParticleSystem _particles;
    [SerializeField] private Movement _movement;
    [SerializeField] private GameObject[] _projectiles;
    [SerializeField] private Transform _spawnTransform;

    public void UpdateSkill()
    {
        SpawnSkill();
    }

    private void SpawnSkill()
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            collision.GetComponent<CharacterHealth>().TakeDamage(_damage);
            Instantiate(_particles, transform.position, Quaternion.identity);
            //
        }
    }
}
