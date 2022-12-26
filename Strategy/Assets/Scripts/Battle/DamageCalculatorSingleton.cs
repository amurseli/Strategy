using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCalculatorSingleton : MonoBehaviour 
{
    public static DamageCalculatorSingleton Instance { get; private set; }
    
    private void Awake() 
    { 
        // If there is an instance, and it's not me, delete myself.
        
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
    }

    public static float calculateDamage(float power, float attackStat, float foeDefense){
        float damage = 0;
        damage = (power * (attackStat / foeDefense)) / 50f;
        Debug.Log(damage);
        return Mathf.Round(damage);
    }
}