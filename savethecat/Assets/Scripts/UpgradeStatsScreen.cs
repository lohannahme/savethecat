using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class UpgradeStatsScreen : MonoBehaviour

{
    public int currentLevel;
    public int currentPrice;
    public TextMeshProUGUI price, level, coins;
    public string typeCow, typeChicken;


    private void Start()
    {
        PlayerPrefs.SetInt("Coins", 1000000);
        PlayerPrefs.SetInt("coinPrice"+ typeChicken, 100);
        coins.text = "Coins: " + PlayerPrefs.GetInt("Coins").ToString();
        price.text = "Price: " + PlayerPrefs.GetInt("coinPriceChickenSpeed").ToString();
        level.text = "Level: " + PlayerPrefs.GetInt("Level"+ typeChicken).ToString();
    }
    public void ChickenDamage() {
       
        
        if (PlayerPrefs.GetInt("Coins")>= PlayerPrefs.GetInt("coinPrice"+ typeChicken)) {

            PlayerPrefs.SetInt("Level" + typeChicken, PlayerPrefs.GetInt("Level" + typeChicken) + 1); ;

            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins")- PlayerPrefs.GetInt("coinPrice"+ typeChicken));
            PlayerPrefs.SetInt("coinPrice"+ typeChicken, PlayerPrefs.GetInt("coinPrice"+ typeChicken) *2);
            price.text = "Price: " + PlayerPrefs.GetInt("coinPrice"+ typeChicken).ToString();
            level.text = "Level: " + PlayerPrefs.GetInt("Level"+ typeChicken).ToString();
            coins.text = "Coins: " + PlayerPrefs.GetInt("Coins");


        }

    }


    public void ChickenHp() { }
 //   public void ChickenDamage() { }

}
