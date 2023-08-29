using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Punch : AttackStrategy
{

    public string _name = "Punch";
    public int power = 80;


    public bool executeAttack(Unit unit, Unit enemyUnit){
        return enemyUnit.TakeDamage((int)DamageCalculatorSingleton.CalculateDamge(power, unit, enemyUnit));
        //DialogueManagerSingleton.addDialogueLine($"{attacker._base._name} uses Punch");
    }

    public string getName(){
        return this._name;
    }
}