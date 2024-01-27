using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    [SerializeField]
    private Text infoText;
    [SerializeField]
    private GameObject gameOverScreen;
    private PlayerHealth player;
    

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        player.OnDeath.AddListener(OnPlayerDead);
        StartCoroutine(GameStarted());
    }

    IEnumerator GameStarted()
    {
        infoText.text = "Start";
        yield return new WaitForSeconds(2);
        infoText.text = "";
    }

    public void OnPlayerDead()
    {
        Debug.Log("Dead");
        StartCoroutine(GameEnded());
    }

    IEnumerator GameEnded()
    {
        gameOverScreen.SetActive(true);
        yield return new WaitForSeconds(5);
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}