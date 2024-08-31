using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    [SerializeField] private HealthBar hp;
    private int health = 100;
    private int maxHealth = 100;
    public void DealDamage(int dmg)
    {
        health -= dmg;
        hp.DisplayHealth(health, maxHealth);
    }
    public void HealhHP()
    {
        if (health < 100 && health > 90)
        {
            health = 100;
        }
        if (health <= 90)
        {
            health += 10;
        }
        hp.DisplayHealth(health, maxHealth);
    }
}
