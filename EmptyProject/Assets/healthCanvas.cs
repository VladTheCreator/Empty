using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthCanvas : MonoBehaviour
{
    [SerializeField] private Image bar;
    [SerializeField] private float widthHealth;
    [SerializeField] private int maxHealth;
    [SerializeField] private healthbar code;
    [SerializeField] int health;

    public void DisplayHealth()
    {
        float healthPercent = ((float)code.health / (float)maxHealth) * 100;
        bar.GetComponent<RectTransform>().sizeDelta = new Vector2(widthHealth / 100 * healthPercent, bar.GetComponent<RectTransform>().sizeDelta.y);
    }
}
