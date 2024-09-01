using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTouch : MonoBehaviour
{
    [SerializeField] GameObject Enemy;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
    }
}
