using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfidenceBreaker : AttackStrategy
{

    private CombatantBase attacker;
    private CombatantBase rival;

    public ConfidenceBreaker(CombatantBase attacker){
        this.attacker = attacker;
    }

    public BattleState executeAttack(BattleState battle){
        this.rival = attacker.getRival();
        rival.Attack.diminishStat(1);
        DialogueManagerSingleton.addDialogueLine($"{attacker._base._name} uses Confidence Breaker");
        return battle;
    }
}
