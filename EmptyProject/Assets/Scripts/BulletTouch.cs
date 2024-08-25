using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTouch : MonoBehaviour
{
    [SerializeField] GameObject Bullet;
    [SerializeField] GameObject Coin;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(Bullet);
            GameObject CoinInstance = Instantiate(Coin);
            CoinInstance.transform.position = collision.gameObject.transform.position;
        }
    }
}