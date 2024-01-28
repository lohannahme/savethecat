using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField]
    private float gameOverScreenTime = 5;

    void Start()
    {
       StartCoroutine(GameEnded());
    }

    IEnumerator GameEnded()
    {
        yield return new WaitForSeconds(gameOverScreenTime);
        SceneManager.LoadScene((int)ScenesEnum.MENU);
    }
}
