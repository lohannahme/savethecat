using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkills : MonoBehaviour
{
    [SerializeField] private GameObject[] _skill;
    [SerializeField] private Transform _spawnTransform;

    [SerializeField] private bool _hasEggs;
    [SerializeField] private ExplosiveEggsSkill skill;
    [SerializeField] private float aa;

    private Movement _playerMovement;

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
        skill.UpdateSkill();
    }
}
