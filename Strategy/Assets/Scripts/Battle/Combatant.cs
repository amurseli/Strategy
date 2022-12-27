using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Combatant", menuName = "Strategy/Combatant")]
public class Combatant : ScriptableObject {
    
    //initial stats for inspector edition

    public float initAttack;
    public float initDefense;

    //stats

    public float maxHealth = 50;
    [HideInInspector]
    public float health;

    public CombatantStatistic attack = new CombatantStatistic(10);
    public CombatantStatistic defense = new CombatantStatistic(10);

    private Combatant rival;
     
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

    public void SetStatistics(){
        attack = new CombatantStatistic(initAttack);
        defense = new CombatantStatistic(initDefense);
        move1 = new Punch(this);
        move2 = new ConfidenceBreaker(this);
        health = maxHealth;
    }

    private void Start() {
        health = maxHealth;
    }

    public void recieveDamage(float damage){

        health = health - damage;
    }

    public void setRival(Combatant rival){
        this.rival = rival;
    }

    public Combatant getRival(){
        return rival;
    }

}

