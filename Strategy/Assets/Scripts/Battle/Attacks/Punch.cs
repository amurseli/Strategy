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
        Debug.Log(rival);
        Debug.Log("Enemy Defense" + rival.Defense.getStatistic());
        float damage = DamageCalculatorSingleton.calculateDamage(power, attacker.Attack.getStatistic(), rival.Defense.getStatistic());
        rival.recieveDamage(damage);

        return battle;
    }
}
