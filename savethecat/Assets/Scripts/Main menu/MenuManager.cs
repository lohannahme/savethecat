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
        StartCoroutine(StartGame(index));
    }

    IEnumerator StartGame(int index)
    {
        yield return new WaitForSeconds(1.5f);

        ScenesEnum sceneIndex = index == 0 ? ScenesEnum.GAME_COW : ScenesEnum.GAME_CHICKEN;
        SceneManager.LoadScene((int)sceneIndex);
    }
}
