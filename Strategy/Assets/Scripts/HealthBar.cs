using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI screenValue;

    public void SetMaxHealth(float health){
        slider.maxValue = health;
    }

    public void SetHealth(float health){
        slider.value = health;
        screenValue.text = health.ToString();
    }

}
