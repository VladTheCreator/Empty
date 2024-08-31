using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image bar;
    [SerializeField] private float widthHealth;
    public void DisplayHealth(float health, float maxHealth)
    {
        float healthPercent = health / maxHealth * 100;
        bar.GetComponent<RectTransform>().sizeDelta = new Vector2(widthHealth / 100 * healthPercent, bar.GetComponent<RectTransform>().sizeDelta.y);
    }
}
