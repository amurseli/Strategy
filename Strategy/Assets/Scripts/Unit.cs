using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public string unitName;
    public int unitLevel;
    public int damage;
    public int maxHP;
    public int currentHP;

    public AttackStrategy attack1 = new Punch();
    
    public AttackStrategy attack2;
    
    public AttackStrategy attack3;
    
    public AttackStrategy attack4;

    public void executeAttack(int attackNumber, Unit enemyUnit){
        Debug.Log("Unit Execute Attack");
        if(attackNumber == 1){
            attack1.executeAttack(enemyUnit);
        }
        else if(attackNumber == 2){
            attack2.executeAttack(enemyUnit);
        }
        else if(attackNumber == 3){
            attack3.executeAttack(enemyUnit);
        }
        else{
            attack4.executeAttack(enemyUnit);
        }
    }

    public bool TakeDamage(int dmg){
        currentHP -= dmg;

        if(currentHP <= 0){
            return true;
        }else{
            return false;
        }
    }
}
