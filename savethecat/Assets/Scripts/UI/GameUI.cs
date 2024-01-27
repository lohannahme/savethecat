using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] private Image _xpBar;

    private void OnEnable()
    {
        PlayerXPManager.UpdateExperience += UpdateXPBar;
    }

    private void OnDisable()
    {
        PlayerXPManager.UpdateExperience -= UpdateXPBar;
    }

    private void UpdateXPBar(float xpAmount, float totalXP)
    {
        _xpBar.fillAmount = xpAmount / totalXP;
    }
}
