using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Combatant", menuName = "Strategy/Combatant", order = 0)]
public class Combatant : ScriptableObject {
    
    //initial stats for inspector edition

    [SerializeField]public float initAttack;
    [SerializeField]public float initDefense;

    //stats

    public float maxHealth = 50;
    [HideInInspector]
    public float health;

    public CombatantStatistic attack;
    public CombatantStatistic defense;
     
    public AttackStrategy move1;
    public AttackStrategy move2;
    public AttackStrategy move3;
    public AttackStrategy move4;


    public Combatant(){
        attack = new CombatantStatistic(initAttack);
        defense = new CombatantStatistic(initDefense);
        move1 = new Punch(this);
        move2 = new ConfidenceBreaker(this);
    }

    private void Awake() {
        health = maxHealth;
    }

    public void recieveDamage(float damage){

        health = health - damage;
    }

}

