using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : AttackStrategy
{
    private CombatantBase attacker;
    private CombatantBase rival;

    public float power = 80;

    public Punch(CombatantBase attacker){
        this.attacker = attacker;
    }

    public BattleState executeAttack(BattleState battle){
        rival = attacker.getRival();
        float damage = DamageCalculatorSingleton.calculateDamage(power, attacker, rival);
        rival.recieveDamage(damage);
        DialogueManagerSingleton.addDialogueLine($"{attacker._base._name} uses Punch");

        return battle;
    }
}
