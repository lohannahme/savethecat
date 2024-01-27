using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerXPManager : MonoBehaviour
{
    private float _currentXP = 0;
    private float _xpToNextLevel = 20;

    public static Action<float, float> UpdateExperience;

    public void UpdatePlayerExperience(float experience)
    {
        _currentXP += experience;
        UpdateExperience?.Invoke(_currentXP, _xpToNextLevel);
    }
}
