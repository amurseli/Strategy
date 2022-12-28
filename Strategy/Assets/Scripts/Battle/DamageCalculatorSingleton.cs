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

    public static float calculateDamage(float movePower, CombatantBase user, CombatantBase target){
        float damage = 0;

        float userAtk = user.Attack.getStatistic();
        float targetDef = user.Defense.getStatistic();
        float userLvl = user.getLevel();

        Debug.Log("Attack: " + userAtk + " Defense: " + targetDef);
        damage = Mathf.CeilToInt(((((2 * userLvl) / 5) + 2 ) * movePower * (userAtk / targetDef)) / 50f);
        Debug.Log(damage);
        return damage;
    }
}