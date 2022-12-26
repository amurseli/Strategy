using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : AttackStrategy
{
    public BattleState executeAttack(BattleState battle){
        
        battle.foe.recieveDamage(10);
        Debug.Log("Punch executed!");

        return battle;
    }
}
