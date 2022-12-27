using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : AttackStrategy
{
    private Combatant attacker;
    private Combatant rival;

    public float power = 80;

    public Punch(Combatant attacker){
        this.attacker = attacker;
        this.rival = attacker.getRival();
    }

    public BattleState executeAttack(BattleState battle){

        float damage = DamageCalculatorSingleton.calculateDamage(power, attacker.attack.getStatistic(), rival.defense.getStatistic());
        rival.recieveDamage(damage);

        return battle;
    }
}
