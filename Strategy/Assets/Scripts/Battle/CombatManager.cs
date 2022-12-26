using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    public BattleState battleState;

    public void computeTurn (BattleState battle, AttackStrategy myAttack, AttackStrategy foeAttack){
        battleState = myAttack.executeAttack(battle);
        battle.foeHealthBar.SetHealth(battle.foe.health);
    }
}
