using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    [SerializeField] private Image bar;
    [SerializeField] private float widthHealth;
    [SerializeField] private int maxHealth;
    [SerializeField] private healthCanvas display;
    [SerializeField] public int health;

    void Start()
    {
        health = 100;
        dealDamage(30);
    }

    // Update is called once per frame
    public void dealDamage(int dmg)
    {
        health -= dmg;
        display.DisplayHealth();
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
        display.DisplayHealth();
    }

}
