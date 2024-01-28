using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private int _characterIndex;

    public void ChooseCharacter(int index)
    {
        _characterIndex = index;
        PlayerPrefs.SetInt("CharacterIndex", _characterIndex);
        StartGame(index);
    }

    public void StartGame(int index)
    {
        ScenesEnum sceneIndex = index == 0 ? ScenesEnum.GAME_COW : ScenesEnum.GAME_CHICKEN;

        SceneManager.LoadScene((int)sceneIndex);
    }
}
