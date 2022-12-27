using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    public BattleState battleState;

    private void Start() {
        battleState.foe.SetStatistics();
        battleState.player.SetStatistics();  
        battleState.foeHealthBar.SetHealth(battleState.foe.health); 
        battleState.playerHealthBar.SetHealth(battleState.player.health); 
    }

    public void computeTurn (BattleState battle, AttackStrategy myAttack, AttackStrategy foeAttack){
        battleState = myAttack.executeAttack(battleState);
        battleState.foeHealthBar.SetHealth(battleState.foe.health);
        battleState = foeAttack.executeAttack(battleState);
        battleState.playerHealthBar.SetHealth(battleState.player.health);
    }
}
