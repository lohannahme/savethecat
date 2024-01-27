using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkills : MonoBehaviour
{
    [SerializeField] private GameObject[] _skill;
    [SerializeField] private Transform _spawnTransform;

    [SerializeField] private bool _hasEggs;
    [SerializeField] private GameObject _eggs;

    private Movement _playerMovement;
    private float _eggsTime = 3;
    private void Start()
    {
        _playerMovement = GetComponent<Movement>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (_playerMovement.isFacingRight)
            {
                Instantiate(_skill[0], _spawnTransform.position, Quaternion.identity);
            }
            else
            {
                Instantiate(_skill[1], _spawnTransform.position, Quaternion.identity);
            }
        }
        SpawnEggs();
    }

    private void SpawnEggs()
    {
        if (Time.time > _eggsTime)
        {
            Instantiate(_eggs, transform.position, Quaternion.identity);
            _hasEggs = false;
            _eggsTime = 3 + Time.time;
        }
    }
}
