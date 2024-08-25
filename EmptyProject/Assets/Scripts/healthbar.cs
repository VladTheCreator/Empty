using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class healthbar : MonoBehaviour
{
    [SerializeField] private Image bar;
    [SerializeField] private float widthHealth;
    [SerializeField] private int maxHealth;
    [SerializeField] private HP hp;
    public int health = 100;
    public void dealDamage(int dmg)
    {
        health -= dmg;
        hp.DisplayHealth();
    }
    public void healhHP()
    {
        if (health < 100 && health > 90)
        {
            health = 100;
        }
        if (health <= 90)
        {
            health += 10;
        }
        hp.DisplayHealth();
    }
}
