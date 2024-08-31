using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTouch : MonoBehaviour
{
    [SerializeField] GameObject Coin;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            GameObject CoinInstance = Instantiate(Coin);
            CoinInstance.transform.position = collision.gameObject.transform.position;
        }
    }
}
