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
        PlayerSkills.SelectHabilitie += HabilitieSelected;
    }

    private void OnDisable()
    {
        PlayerXPManager.UpdateExperience -= UpdateXPBar;
        PlayerXPManager.LevelUp -= LevelUp;
        PlayerSkills.SelectHabilitie -= HabilitieSelected;
    }

    private void UpdateXPBar(float xpAmount, float totalXP)
    {
        _xpBar.fillAmount = xpAmount / totalXP;
    }

    private void LevelUp()
    {
        _levelUpPanel.SetActive(true);
        Time.timeScale = 0;
    }

    private void HabilitieSelected()
    {
        _levelUpPanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void Test(int indes)
    {
        Debug.Log("uiui" + indes);
    }
}
