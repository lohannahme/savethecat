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
        StartGame();
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
