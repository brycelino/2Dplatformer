using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectingCoin : MonoBehaviour
{
    public Text PlayerCoins;

    private void Start()
    {
        PlayerCoins = GetComponent<Text>();
    }

    
    private void OnTriggerEnter2D(Collider2D Coin)
    {
        if(Coin.gameObject.CompareTag("Player"))
        {
        GameManager.instance.score++;
            Destroy(Coin.gameObject);

        }

    }

    private void Update()
    {
        PlayerCoins.text = "Coins: " + GameManager.instance.score;
    }
}
