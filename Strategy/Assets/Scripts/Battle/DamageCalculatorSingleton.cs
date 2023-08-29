using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCalculatorSingleton : MonoBehaviour
{
    private static DamageCalculatorSingleton instance;

    private DamageCalculatorSingleton() { }

    public static DamageCalculatorSingleton Instance{
        get{
            if(instance == null){
                instance = new DamageCalculatorSingleton();
            }
            return instance;
        }
    }

    static public float CalculateDamge(int power, Unit unit, Unit target){

        float critical = 1f;

        if(UnityEngine.Random.Range(0, 100) >= 95){
            critical  = 1.5f; 
        } 

        float level = (float)unit.unitLevel;
        float atk = (float)unit.Attack;
        float def = (float)target.Defense;

        float damage = ((((2*level*critical)/5 + 2) * (float)power * (atk/def))/50)+2;
    
        damage = damage * UnityEngine.Random.Range(0.9f,1.1f);
        Debug.Log(damage);
        return (int)damage;
    }
}
