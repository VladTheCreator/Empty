using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTouch : MonoBehaviour
{
    [SerializeField] GameObject Enemy;
    [SerializeField] Health health;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health.DealDamage(10);
            Destroy(collision.gameObject);
        }
    }
}
