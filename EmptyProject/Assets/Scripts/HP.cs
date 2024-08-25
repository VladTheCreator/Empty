using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HP : MonoBehaviour
{
    [SerializeField] private Image bar;
    [SerializeField] private healthbar health;
    [SerializeField] private float widthHealth;
    [SerializeField] private int maxHealth;
    public void DisplayHealth()
    {
        float healthPercent = ((float)health.health / (float)maxHealth) * 100;
        bar.GetComponent<RectTransform>().sizeDelta = new Vector2(widthHealth / 100 * healthPercent, bar.GetComponent<RectTransform>().sizeDelta.y);
    }
}
