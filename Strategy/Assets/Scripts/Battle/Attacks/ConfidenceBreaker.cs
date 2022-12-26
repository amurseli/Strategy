using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfidenceBreaker : AttackStrategy
{

    private Combatant attacker;

    public ConfidenceBreaker(Combatant attacker){
        this.attacker = attacker;
    }

    public BattleState executeAttack(BattleState battle){
        Debug.Log("Stats Diminshed!");
        battle.foe.attack.diminishStat(1);
        return battle;
    }
}
