using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerSkills : MonoBehaviour
{

    [SerializeField] private bool _hasEggs;

    [SerializeField] private ExplosiveEggsSkill skill;
    [SerializeField] private ChickenBasicSkill _basicSkill;
    [SerializeField] private ForkAbility _forksSkill;
    public bool _axeSkill;


    private Movement _playerMovement;
    private bool _hasForks;

    public static Action SelectHabilitie;


    void Update()
    {

        //_basicSkill.UpdateSkill();

        if (_hasEggs)
        {
            skill.UpdateSkill();
        }
    }

    public void UpdateHabilities(int i)
    {
        switch (i)
        {
            case 0://upar atkbasikco
            if (!_hasEggs)
                {
            _axeSkill = true;
            }
                break;
            case 1:
                if (!_hasEggs)
                {
                    _hasEggs = true;
                }
                else
                {
                    //updateHabilitie
                }
                break;
            case 2:
                if (!_hasForks)
                {
                    _hasForks = true;
                    _forksSkill.gameObject.SetActive(true);
                }
                else
                {
                    //updateHabilitie
                }
                break;
        }
        SelectHabilitie?.Invoke();
    }
}
