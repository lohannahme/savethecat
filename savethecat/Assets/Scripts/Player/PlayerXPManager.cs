using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerXPManager : MonoBehaviour
{
    private float _currentXP = 0;
    private float _xpToNextLevel = 10;
    private int _playerLevel = 1;
    private int _xpConst = 10;


    public static Action<float, float> UpdateExperience;
    public static Action LevelUp;


    public void UpdatePlayerExperience(float experience)
    {
        _currentXP += experience;

        if (_currentXP >= _xpToNextLevel)
        {
            LevelUp?.Invoke();
            _playerLevel++;
            UpdatePlayerLevel();
        }

        UpdateExperience?.Invoke(_currentXP, _xpToNextLevel);
    }

    private void UpdatePlayerLevel()
    {
        _currentXP = 0;
        _xpToNextLevel = _xpConst * _playerLevel;
        LevelUp?.Invoke();
    }
}
