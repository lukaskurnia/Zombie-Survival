using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public float MAX_HEALTH = 100f;
    public float health;

    public void SetMaxHealth() {
        slider.maxValue = MAX_HEALTH;
        slider.value = MAX_HEALTH;

        fill.color = gradient.Evaluate(1f);
    }
    public void SetHealth(float health) {
        slider.value = health;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
