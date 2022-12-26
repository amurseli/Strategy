using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : AttackStrategy
{
    private Combatant attacker;

    public float power = 80;

    public Punch(Combatant attacker){
        this.attacker = attacker;
    }

    public BattleState executeAttack(BattleState battle){

        float damage = DamageCalculatorSingleton.calculateDamage(power, attacker.attack.getStatistic(), battle.foe.defense.getStatistic());
        battle.foe.recieveDamage(damage);

        return battle;
    }
}
