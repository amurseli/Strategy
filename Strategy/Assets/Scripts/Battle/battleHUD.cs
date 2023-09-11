using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class battleHUD : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI valueHP;
    public Slider hpSlider;

    public void SetHUD(Unit unit){
        nameText.text = unit.unitName;
        levelText.text = "Lvl " + unit.unitLevel;
        hpSlider.maxValue = unit.maxHP;
        valueHP.text =  unit.currentHP.ToString();
        hpSlider.value = unit.currentHP;
    }

    public void SetHP(int hp){
        hpSlider.value = hp;
        valueHP.text =  hp.ToString();
    }
}
