using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : AttackStrategy
{

    public int power = 80;


    public void executeAttack(Unit enemyUnit){
        Debug.Log("Punch");
        enemyUnit.TakeDamage(power/10);
        //DialogueManagerSingleton.addDialogueLine($"{attacker._base._name} uses Punch");
    }
}