using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfidenceBreaker : AttackStrategy
{

    private Combatant attacker;
    private Combatant rival;

    public ConfidenceBreaker(Combatant attacker){
        this.attacker = attacker;
        this.rival = attacker.getRival();
    }

    public BattleState executeAttack(BattleState battle){
        rival.attack.diminishStat(1);
        return battle;
    }
}
