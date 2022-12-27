using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatantStatistic{
    public float value;
    public float trueValue;

    public int modifier = 0;

    public CombatantStatistic(float value){
        this.value = value;
        this.trueValue = value;
    }

    public void diminishStat(int times){
        if(modifier > -6){
            value = Mathf.Round(value - (trueValue * (times * 0.1f)));
            modifier--;
        }
    }

    public float getStatistic(){
        return value;
    }
}
