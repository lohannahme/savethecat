using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerXPManager : MonoBehaviour
{
    private float _currentXP = 0;
    private float _xpToNextLevel = 10;
    private int _playerLevel = 1;
    private int _xpConst = 10; // constante que multiplica o level do jogador pra calcular a experiencia que precisa pro proximo nivel


    public static Action<float, float> UpdateExperience; // ação que dá update na barra de experiencia do jogador
    public static Action LevelUp; // açao chamada quando o jogador upa de level, ela zera a experiencia atual e ativa o canvas de seleçao de habilidades


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
