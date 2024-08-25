using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinPickUp : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    int amountOfCoins = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
            amountOfCoins++;
            text.text = amountOfCoins.ToString();
        }
    }
}