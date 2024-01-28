using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkills : MonoBehaviour
{

    [SerializeField] private bool _hasEggs;
    [SerializeField] private ExplosiveEggsSkill skill;
    [SerializeField] private ChickenBasicSkill _basicSkill;


    private Movement _playerMovement;

    private void Start()
    {

    }

    void Update()
    {

        _basicSkill.UpdateSkill();
        //skill.UpdateSkill();
    }
}
