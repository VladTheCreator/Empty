using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class CoinPickUP : WinPanelActivator
{
    [SerializeField] private TMP_Text text;
    int amountOfCoins = 0;
    int winAmount = 5;
    void Start()
    {
        TurnOffWinPanel();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            amountOfCoins++;
            text.text = amountOfCoins.ToString();
        }
        if (amountOfCoins >= winAmount)
        {
            TurnOnWinPanel();
        }
    }
}