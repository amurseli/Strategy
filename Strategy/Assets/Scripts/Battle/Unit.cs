using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public Combatant _base;
    public string unitName;
    public int unitLevel;
    public int maxHP;
    public int currentHP;
    public int Attack{ get; set; }
    public int Defense{ get; set; }

    public battleHUD HUD;

    public AttackStrategy attack1 = new Punch();
    
    public AttackStrategy attack2;
    
    public AttackStrategy attack3;
    
    public AttackStrategy attack4;

    public void Awake(){
        unitName = _base.name;
        maxHP = _base.hp;
        currentHP = _base.hp;
        unitLevel = _base.level;
        Attack = _base.getStat(_base.baseAttack);
        Defense = _base.getStat(_base.baseDefense);
        int Speed = _base.getStat(_base.baseSpeed);
        //Sprite characterSprite = _base.characterSprite;
    }

    public bool executeAttack(int attackNumber, Unit enemyUnit){
        if(attackNumber == 1){
            return attack1.executeAttack(this,enemyUnit);
        }
        else if(attackNumber == 2){
            return attack2.executeAttack(this,enemyUnit);
        }
        else if(attackNumber == 3){
            return attack3.executeAttack(this,enemyUnit);
        }
        else{
            return attack4.executeAttack(this,enemyUnit);
        }
    }

    public bool TakeDamage(int dmg){
        currentHP -= dmg;
        HUD.SetHP(currentHP);
        if(currentHP <= 0){
            return true;
        }else{
            return false;
        }
    }

    public string getAttackByNumber(int attackNumber){
        switch (attackNumber)
        {
            case 1:
                return attack1.getName();
            case 2:
                return attack2.getName();
            case 3:
                return attack3.getName();
            default:
                return attack4.getName();
        }
    }
 
    public void setHUD(){
        HUD.SetHUD(this);
    }

    public battleHUD getHUD() { return this.HUD; }
}
