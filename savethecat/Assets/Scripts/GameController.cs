using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    [SerializeField]
    private GameObject gameOverScreen;
    [SerializeField]
    private float gameOverScreenTime = 5;
    private PlayerHealth player;
    

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        player.OnDeath.AddListener(OnPlayerDead);
        gameOverScreen.SetActive(false);
    }

    public void OnPlayerDead()
    {
        Debug.Log("Dead");
        StartCoroutine(GameEnded());
    }

    IEnumerator GameEnded()
    {
        gameOverScreen.SetActive(true);
        yield return new WaitForSeconds(gameOverScreenTime);
        SceneManager.LoadScene((int)ScenesEnum.MENU);
    }
}
