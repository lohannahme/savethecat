using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] private Image _xpBar;

    [SerializeField] private GameObject _levelUpPanel;

    private void OnEnable()
    {
        PlayerXPManager.UpdateExperience += UpdateXPBar;
        PlayerXPManager.LevelUp += LevelUp;
    }

    private void OnDisable()
    {
        PlayerXPManager.UpdateExperience -= UpdateXPBar;
        PlayerXPManager.LevelUp -= LevelUp;
    }

    private void UpdateXPBar(float xpAmount, float totalXP)
    {
        _xpBar.fillAmount = xpAmount / totalXP;
    }

    private void LevelUp()
    {
        Time.timeScale = 0;
    }
}
