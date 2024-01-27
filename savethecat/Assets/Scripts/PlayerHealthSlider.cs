using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthSlider : MonoBehaviour
{
    private Slider slider;
    private PlayerStats player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>();
        slider = GetComponent<Slider>();
    }

    void Update()
    {
        slider.value = player.GetHealthPoints() / player.GetMaxHp();
    }
}
